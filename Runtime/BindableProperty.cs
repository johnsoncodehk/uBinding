using UnityEngine;
using UnityEngine.Events;

public class BindableProperty<TValue> : BindableProperty<TValue, BindableProperty<TValue>.TEvent, BindableProperty<TValue>>
{
    public class TEvent : UnityEvent<TValue> { }
}
public class BindableProperty<TValue, TEvent, TChild> : BindableProperty
    where TEvent : UnityEvent<TValue>, new()
    where TChild : BindableProperty<TValue, TEvent, TChild>
{

    [SerializeField] private TValue m_Value;
    public TValue value
    {
        get => m_Value;
        set
        {
            m_Value = value;
            OnValueUpdate();
        }
    }

    [SerializeField] private TEvent m_Binding = new TEvent();
    public virtual TEvent binding => m_Binding;

    public BindableProperty() { }
    public BindableProperty(TValue value)
    {
        this.value = value;
    }

    public virtual void Bind(UnityAction<TValue> call)
    {
        binding.AddListener(call);
        call(value);
    }
    public virtual void Unbind(UnityAction<TValue> call)
    {
        binding.RemoveListener(call);
    }
    public override void OnValueUpdate()
    {
        binding.Invoke(value);
    }


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
    public abstract void OnValueUpdate();
}
