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
    public class BindableString : BindableProperty<string, StringEventHandler, BindableString>
    {
        public BindableString(string value) : base(value) { }
    }

    [Serializable]
    public class BindableInt : BindableProperty<int, IntEventHandler, BindableInt>
    {
        public BindableInt(int value) : base(value) { }
    }

    [Serializable]
    public class BindableFloat : BindableProperty<float, FloatEventHandler, BindableFloat>
    {
        public BindableFloat(float value) : base(value) { }
    }

    [Serializable]
    public class BindableBool : BindableProperty<bool, BoolEventHandler, BindableBool>
    {
        public BindableBool(bool value) : base(value) { }
    }

    [Serializable]
    public class BindableColor : BindableProperty<Color, ColorEventHandler, BindableColor>
    {
        public BindableColor(Color value) : base(value) { }
    }

    [Serializable]
    public class BindableGradient : BindableProperty<Gradient, GradientEventHandler, BindableGradient>
    {
        public BindableGradient(Gradient value) : base(value) { }
    }

    [Serializable]
    public class BindableMatrix4x4 : BindableProperty<Matrix4x4, Matrix4x4EventHandler, BindableMatrix4x4>
    {
        public BindableMatrix4x4(Matrix4x4 value) : base(value) { }
    }

    [Serializable]
    public class BindableQuaternion : BindableProperty<Quaternion, QuaternionEventHandler, BindableQuaternion>
    {
        public BindableQuaternion(Quaternion value) : base(value) { }
    }

    [Serializable]
    public class BindableVector2 : BindableProperty<Vector2, Vector2EventHandler, BindableVector2>
    {
        public BindableVector2(Vector2 value) : base(value) { }
    }

    [Serializable]
    public class BindableVector3 : BindableProperty<Vector3, Vector3EventHandler, BindableVector3>
    {
        public BindableVector3(Vector3 value) : base(value) { }
    }

    [Serializable]
    public class BindableVector4 : BindableProperty<Vector4, Vector4EventHandler, BindableVector4>
    {
        public BindableVector4(Vector4 value) : base(value) { }
    }

    [Serializable]
    public class BindableVector2Int : BindableProperty<Vector2Int, Vector2IntEventHandler, BindableVector2Int>
    {
        public BindableVector2Int(Vector2Int value) : base(value) { }
    }

    [Serializable]
    public class BindableVector3Int : BindableProperty<Vector3Int, Vector3IntEventHandler, BindableVector3Int>
    {
        public BindableVector3Int(Vector3Int value) : base(value) { }
    }
}
