using UnityEngine;
using UnityEngine.Events;

namespace uBinding
{

    public class Binding<TValue> : Binding<TValue, Binding<TValue>.TEvent>
    {
        public class TEvent : UnityEvent<TValue> { }
        public Binding(TValue value) : base(value) { }
    }

    public class Binding<TValue, TEvent> : Binding
        where TEvent : UnityEvent<TValue>, new()
    {

        [SerializeField] private TValue m_Value;
        public TValue value
        {
            get => m_Value;
            set
            {
                m_Value = value;
                OnValueChange();
            }
        }

        [SerializeField] private TEvent m_OnValueChanged = new TEvent();
        public virtual TEvent onValueChanged => m_OnValueChanged;

        public Binding() { }
        public Binding(TValue value) => this.value = value;

        public virtual void Bind(UnityAction<TValue> call)
        {
            onValueChanged.AddListener(call);
            call(value);
        }
        public virtual void Unbind(UnityAction<TValue> call)
        {
            onValueChanged.RemoveListener(call);
        }
        public override void OnValueChange()
        {
            onValueChanged.Invoke(value);
        }
    }

    public class Binding<TValue, TEvent, TChild> : Binding<TValue, TEvent>
        where TEvent : UnityEvent<TValue>, new()
        where TChild : Binding<TValue, TEvent, TChild>
    {

        public Binding(TValue value) : base(value) { }

        public static TChild operator +(Binding<TValue, TEvent, TChild> a, UnityAction<TValue> call)
        {
            a.Bind(call);
            return a as TChild;
        }
        public static TChild operator -(Binding<TValue, TEvent, TChild> a, UnityAction<TValue> call)
        {
            a.Unbind(call);
            return a as TChild;
        }
    }

    public abstract class Binding
    {
        public abstract void OnValueChange();
    }
}
