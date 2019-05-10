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
        public BindableString(string value) => this.value = value;
        public static implicit operator string(BindableString d) => d.value;
        public static implicit operator BindableString(string d) => new BindableString(d);
    }

    [Serializable]
    public class BindableInt : BindableProperty<int, IntEventHandler, BindableInt>
    {
        public BindableInt(int value) => this.value = value;
        public static implicit operator int(BindableInt d) => d.value;
        public static implicit operator BindableInt(int d) => new BindableInt(d);
    }

    [Serializable]
    public class BindableFloat : BindableProperty<float, FloatEventHandler, BindableFloat>
    {
        public BindableFloat(float value) => this.value = value;
        public static implicit operator float(BindableFloat d) => d.value;
        public static implicit operator BindableFloat(float d) => new BindableFloat(d);
    }

    [Serializable]
    public class BindableBool : BindableProperty<bool, BoolEventHandler, BindableBool>
    {
        public BindableBool(bool value) => this.value = value;
        public static implicit operator bool(BindableBool d) => d.value;
        public static implicit operator BindableBool(bool d) => new BindableBool(d);
    }

    [Serializable]
    public class BindableColor : BindableProperty<Color, ColorEventHandler, BindableColor>
    {
        public BindableColor(Color value) => this.value = value;
        public static implicit operator Color(BindableColor d) => d.value;
        public static implicit operator BindableColor(Color d) => new BindableColor(d);
    }

    [Serializable]
    public class BindableGradient : BindableProperty<Gradient, GradientEventHandler, BindableGradient>
    {
        public BindableGradient(Gradient value) => this.value = value;
        public static implicit operator Gradient(BindableGradient d) => d.value;
        public static implicit operator BindableGradient(Gradient d) => new BindableGradient(d);
    }

    [Serializable]
    public class BindableMatrix4x4 : BindableProperty<Matrix4x4, Matrix4x4EventHandler, BindableMatrix4x4>
    {
        public BindableMatrix4x4(Matrix4x4 value) => this.value = value;
        public static implicit operator Matrix4x4(BindableMatrix4x4 d) => d.value;
        public static implicit operator BindableMatrix4x4(Matrix4x4 d) => new BindableMatrix4x4(d);
    }

    [Serializable]
    public class BindableQuaternion : BindableProperty<Quaternion, QuaternionEventHandler, BindableQuaternion>
    {
        public BindableQuaternion(Quaternion value) => this.value = value;
        public static implicit operator Quaternion(BindableQuaternion d) => d.value;
        public static implicit operator BindableQuaternion(Quaternion d) => new BindableQuaternion(d);
    }

    [Serializable]
    public class BindableVector2 : BindableProperty<Vector2, Vector2EventHandler, BindableVector2>
    {
        public BindableVector2(Vector2 value) => this.value = value;
        public static implicit operator Vector2(BindableVector2 d) => d.value;
        public static implicit operator BindableVector2(Vector2 d) => new BindableVector2(d);
    }

    [Serializable]
    public class BindableVector3 : BindableProperty<Vector3, Vector3EventHandler, BindableVector3>
    {
        public BindableVector3(Vector3 value) => this.value = value;
        public static implicit operator Vector3(BindableVector3 d) => d.value;
        public static implicit operator BindableVector3(Vector3 d) => new BindableVector3(d);
    }

    [Serializable]
    public class BindableVector4 : BindableProperty<Vector4, Vector4EventHandler, BindableVector4>
    {
        public BindableVector4(Vector4 value) => this.value = value;
        public static implicit operator Vector4(BindableVector4 d) => d.value;
        public static implicit operator BindableVector4(Vector4 d) => new BindableVector4(d);
    }

    [Serializable]
    public class BindableVector2Int : BindableProperty<Vector2Int, Vector2IntEventHandler, BindableVector2Int>
    {
        public BindableVector2Int(Vector2Int value) => this.value = value;
        public static implicit operator Vector2Int(BindableVector2Int d) => d.value;
        public static implicit operator BindableVector2Int(Vector2Int d) => new BindableVector2Int(d);
    }

    [Serializable]
    public class BindableVector3Int : BindableProperty<Vector3Int, Vector3IntEventHandler, BindableVector3Int>
    {
        public BindableVector3Int(Vector3Int value) => this.value = value;
        public static implicit operator Vector3Int(BindableVector3Int d) => d.value;
        public static implicit operator BindableVector3Int(Vector3Int d) => new BindableVector3Int(d);
    }
}
