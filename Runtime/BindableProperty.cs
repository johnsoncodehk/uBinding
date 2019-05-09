using UnityEngine;
using UnityEngine.Events;

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
            OnValueUpdate();
        }
    }

    [SerializeField] private TEvent m_Binding = new TEvent();
    public virtual TEvent binding => m_Binding;

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
}
public abstract class BindableProperty
{
    public abstract void OnValueUpdate();
}
