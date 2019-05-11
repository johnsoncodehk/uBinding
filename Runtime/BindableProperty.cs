using UnityEngine;
using UnityEngine.Events;

namespace uBinding
{

    public class BindableProperty<TValue> : BindableProperty<TValue, BindableProperty<TValue>.TEvent>
    {
        public class TEvent : UnityEvent<TValue> { }
        public BindableProperty(TValue value) : base(value) { }
    }

    public class BindableProperty<TValue, TEvent> : BindableProperty
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

        public BindableProperty() { }
        public BindableProperty(TValue value) => this.value = value;

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

    public class BindableProperty<TValue, TEvent, TChild> : BindableProperty<TValue, TEvent>
        where TEvent : UnityEvent<TValue>, new()
        where TChild : BindableProperty<TValue, TEvent, TChild>
    {

        public BindableProperty(TValue value) : base(value) { }

        public static TChild operator +(BindableProperty<TValue, TEvent, TChild> a, UnityAction<TValue> call)
        {
            a.Bind(call);
            return a as TChild;
        }
        public static TChild operator -(BindableProperty<TValue, TEvent, TChild> a, UnityAction<TValue> call)
        {
            a.Unbind(call);
            return a as TChild;
        }
    }

    public abstract class BindableProperty
    {
        public abstract void OnValueChange();
    }
}
