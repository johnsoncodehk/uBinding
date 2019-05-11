using System;
using UnityEngine;
using UnityEngine.Events;

namespace uBinding
{

    [Serializable] public class StringBindingEvent : UnityEvent<string> { }
    [Serializable] public class IntBindingEvent : UnityEvent<int> { }
    [Serializable] public class FloatBindingEvent : UnityEvent<float> { }
    [Serializable] public class BoolBindingEvent : UnityEvent<bool> { }

    [Serializable] public class ColorBindingEvent : UnityEvent<Color> { }
    [Serializable] public class GradientBindingEvent : UnityEvent<Gradient> { }
    [Serializable] public class Matrix4x4BindingEvent : UnityEvent<Matrix4x4> { }
    [Serializable] public class QuaternionBindingEvent : UnityEvent<Quaternion> { }
    [Serializable] public class Vector2BindingEvent : UnityEvent<Vector2> { }
    [Serializable] public class Vector3BindingEvent : UnityEvent<Vector3> { }
    [Serializable] public class Vector4BindingEvent : UnityEvent<Vector4> { }
    [Serializable] public class Vector2IntBindingEvent : UnityEvent<Vector2Int> { }
    [Serializable] public class Vector3IntBindingEvent : UnityEvent<Vector3Int> { }

    [Serializable]
    public class StringBinding : Binding<string, StringBindingEvent, StringBinding>
    {
        public StringBinding(string value) : base(value) { }
    }

    [Serializable]
    public class IntBinding : Binding<int, IntBindingEvent, IntBinding>
    {
        public IntBinding(int value) : base(value) { }
    }

    [Serializable]
    public class FloatBinding : Binding<float, FloatBindingEvent, FloatBinding>
    {
        public FloatBinding(float value) : base(value) { }
    }

    [Serializable]
    public class BoolBinding : Binding<bool, BoolBindingEvent, BoolBinding>
    {
        public BoolBinding(bool value) : base(value) { }
    }

    [Serializable]
    public class ColorBinding : Binding<Color, ColorBindingEvent, ColorBinding>
    {
        public ColorBinding(Color value) : base(value) { }
    }

    [Serializable]
    public class GradientBinding : Binding<Gradient, GradientBindingEvent, GradientBinding>
    {
        public GradientBinding(Gradient value) : base(value) { }
    }

    [Serializable]
    public class Matrix4x4Binding : Binding<Matrix4x4, Matrix4x4BindingEvent, Matrix4x4Binding>
    {
        public Matrix4x4Binding(Matrix4x4 value) : base(value) { }
    }

    [Serializable]
    public class QuaternionBinding : Binding<Quaternion, QuaternionBindingEvent, QuaternionBinding>
    {
        public QuaternionBinding(Quaternion value) : base(value) { }
    }

    [Serializable]
    public class Vector2Binding : Binding<Vector2, Vector2BindingEvent, Vector2Binding>
    {
        public Vector2Binding(Vector2 value) : base(value) { }
    }

    [Serializable]
    public class Vector3Binding : Binding<Vector3, Vector3BindingEvent, Vector3Binding>
    {
        public Vector3Binding(Vector3 value) : base(value) { }
    }

    [Serializable]
    public class Vector4Binding : Binding<Vector4, Vector4BindingEvent, Vector4Binding>
    {
        public Vector4Binding(Vector4 value) : base(value) { }
    }

    [Serializable]
    public class Vector2IntBinding : Binding<Vector2Int, Vector2IntBindingEvent, Vector2IntBinding>
    {
        public Vector2IntBinding(Vector2Int value) : base(value) { }
    }

    [Serializable]
    public class Vector3IntBinding : Binding<Vector3Int, Vector3IntBindingEvent, Vector3IntBinding>
    {
        public Vector3IntBinding(Vector3Int value) : base(value) { }
    }
}
