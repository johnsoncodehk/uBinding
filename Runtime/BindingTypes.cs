using System;
using UnityEngine;
using UnityEngine.Events;

namespace uBinding
{

    [Serializable] public class StringEventHandler : UnityEvent<string> { }
    [Serializable] public class IntEventHandler : UnityEvent<int> { }
    [Serializable] public class FloatEventHandler : UnityEvent<float> { }
    [Serializable] public class BoolEventHandler : UnityEvent<bool> { }

    [Serializable] public class ColorEventHandler : UnityEvent<Color> { }
    [Serializable] public class GradientEventHandler : UnityEvent<Gradient> { }
    [Serializable] public class Matrix4x4EventHandler : UnityEvent<Matrix4x4> { }
    [Serializable] public class QuaternionEventHandler : UnityEvent<Quaternion> { }
    [Serializable] public class Vector2EventHandler : UnityEvent<Vector2> { }
    [Serializable] public class Vector3EventHandler : UnityEvent<Vector3> { }
    [Serializable] public class Vector4EventHandler : UnityEvent<Vector4> { }
    [Serializable] public class Vector2IntEventHandler : UnityEvent<Vector2Int> { }
    [Serializable] public class Vector3IntEventHandler : UnityEvent<Vector3Int> { }

    [Serializable]
    public class BindableString : Binding<string, StringEventHandler, BindableString>
    {
        public BindableString(string value) : base(value) { }
    }

    [Serializable]
    public class BindableInt : Binding<int, IntEventHandler, BindableInt>
    {
        public BindableInt(int value) : base(value) { }
    }

    [Serializable]
    public class BindableFloat : Binding<float, FloatEventHandler, BindableFloat>
    {
        public BindableFloat(float value) : base(value) { }
    }

    [Serializable]
    public class BindableBool : Binding<bool, BoolEventHandler, BindableBool>
    {
        public BindableBool(bool value) : base(value) { }
    }

    [Serializable]
    public class BindableColor : Binding<Color, ColorEventHandler, BindableColor>
    {
        public BindableColor(Color value) : base(value) { }
    }

    [Serializable]
    public class BindableGradient : Binding<Gradient, GradientEventHandler, BindableGradient>
    {
        public BindableGradient(Gradient value) : base(value) { }
    }

    [Serializable]
    public class BindableMatrix4x4 : Binding<Matrix4x4, Matrix4x4EventHandler, BindableMatrix4x4>
    {
        public BindableMatrix4x4(Matrix4x4 value) : base(value) { }
    }

    [Serializable]
    public class BindableQuaternion : Binding<Quaternion, QuaternionEventHandler, BindableQuaternion>
    {
        public BindableQuaternion(Quaternion value) : base(value) { }
    }

    [Serializable]
    public class BindableVector2 : Binding<Vector2, Vector2EventHandler, BindableVector2>
    {
        public BindableVector2(Vector2 value) : base(value) { }
    }

    [Serializable]
    public class BindableVector3 : Binding<Vector3, Vector3EventHandler, BindableVector3>
    {
        public BindableVector3(Vector3 value) : base(value) { }
    }

    [Serializable]
    public class BindableVector4 : Binding<Vector4, Vector4EventHandler, BindableVector4>
    {
        public BindableVector4(Vector4 value) : base(value) { }
    }

    [Serializable]
    public class BindableVector2Int : Binding<Vector2Int, Vector2IntEventHandler, BindableVector2Int>
    {
        public BindableVector2Int(Vector2Int value) : base(value) { }
    }

    [Serializable]
    public class BindableVector3Int : Binding<Vector3Int, Vector3IntEventHandler, BindableVector3Int>
    {
        public BindableVector3Int(Vector3Int value) : base(value) { }
    }
}
