using System;
using UnityEditor;
using UnityEngine;

namespace uBinding
{

    [CustomPropertyDrawer(typeof(BindableProperty), true)]
    public class BindablePropertyDrawer : PropertyDrawer
    {

        const float kSpacingSubLabel = 2;
        const float kIndentPerLevel = 15;
        static float indent => EditorGUI.indentLevel * kIndentPerLevel;

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            SerializedProperty valueProp = property.FindPropertyRelative("m_Value");

            if (!IsSupportCustomGUI(valueProp))
                return GetValueHeight(property, label);

            float height = GetValueHeight(valueProp, label);

            if (property.isExpanded)
            {
                height += EditorGUI.GetPropertyHeight(property.FindPropertyRelative("m_Binding"));
                height += kSpacingSubLabel;
            }

            return height;
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            string labelText = label.text;
            SerializedProperty valueProp = property.FindPropertyRelative("m_Value");

            if (!IsSupportCustomGUI(valueProp))
            {
                ValueOnGUI(position, property, label);
                return;
            }

            float valuePropHeight = GetValueHeight(valueProp, label);

            Rect foldoutPosition = new Rect(position.x, position.y, indent, valuePropHeight);
            Rect fieldPosition = new Rect(position.x, position.y, position.width, valuePropHeight);

            property.isExpanded = EditorGUI.Foldout(foldoutPosition, property.isExpanded, GUIContent.none);

            float y = position.y;

            EditorGUI.BeginChangeCheck();

            label.text = labelText;
            ValueOnGUI(fieldPosition, valueProp, label);
            y += valuePropHeight + kSpacingSubLabel;

            if (EditorGUI.EndChangeCheck())
            {
                property.serializedObject.ApplyModifiedProperties();
                property.GetValue<BindableProperty>().OnValueUpdate();
            }

            if (property.isExpanded)
            {
                SerializedProperty bindingProp = property.FindPropertyRelative("m_Binding");
                // float bindingPropHeight = EditorGUI.GetPropertyHeight(bindingProp);

                EditorGUI.PropertyField(new Rect(position.x, y, position.width, 0), bindingProp);
                // y += bindingPropHeight + kSpacingSubLabel;
            }
        }

        public bool IsSupportCustomGUI(SerializedProperty valueProp)
        {
            if (!valueProp.hasVisibleChildren)
                return true;

            switch (valueProp.type)
            {
                case "Vector2":
                case "Vector3":
                case "Vector2Int":
                case "Vector3Int":
                    return true;
            }

            return false;
        }
        public virtual float GetValueHeight(SerializedProperty valueProp, GUIContent label)
        {
            return EditorGUI.GetPropertyHeight(valueProp);
        }
        public virtual void ValueOnGUI(Rect position, SerializedProperty valueProp, GUIContent label)
        {
            EditorGUI.PropertyField(position, valueProp, label, true);
        }
    }

    [CustomPropertyDrawer(typeof(RangeAttribute))]
    [CustomPropertyDrawer(typeof(MultilineAttribute))]
    [CustomPropertyDrawer(typeof(TextAreaAttribute))]
    [CustomPropertyDrawer(typeof(ColorUsageAttribute))]
    [CustomPropertyDrawer(typeof(GradientUsageAttribute))]
    [CustomPropertyDrawer(typeof(DelayedAttribute))]
    class BindableAttributeDrawer : BindablePropertyDrawer
    {

        PropertyDrawer baseDrawer;
        bool init;

        void Init()
        {
            if (init) return;
            init = true;

            string typeName = attribute.GetType().FullName
                .Replace("UnityEngine.", "UnityEditor.")
                .Replace("Attribute", "Drawer, UnityEditor");
            Type type = Type.GetType(typeName);

            System.Reflection.FieldInfo attProp = type.GetField("m_Attribute", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            System.Reflection.FieldInfo infoProp = type.GetField("m_FieldInfo", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);

            baseDrawer = Activator.CreateInstance(type) as PropertyDrawer;

            attProp.SetValue(baseDrawer, attProp.GetValue(this));
            infoProp.SetValue(baseDrawer, infoProp.GetValue(this));
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            Init();

            if (IsBindable(property))
                return base.GetPropertyHeight(property, label);
            else
                return baseDrawer.GetPropertyHeight(property, label);
        }
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            Init();

            if (IsBindable(property))
                base.OnGUI(position, property, label);
            else
                baseDrawer.OnGUI(position, property, label);
        }

        public override float GetValueHeight(SerializedProperty valueProp, GUIContent label)
        {
            return baseDrawer.GetPropertyHeight(valueProp, label);
        }
        public override void ValueOnGUI(Rect position, SerializedProperty valueProp, GUIContent label)
        {
            baseDrawer.OnGUI(position, valueProp, label);
        }

        bool IsBindable(SerializedProperty property)
        {
            try
            {
                if (property.GetValue<BindableProperty>() != null)
                    return true;
            }
            catch { }

            return false;
        }
    }
}
