using CommunityToolkit.Maui;

namespace SourceGenBindings;

public partial class CustomButton : Button
{
    [BindableProperty]
    public partial int? Number { get; set; }
    
    public static readonly BindableProperty FooProperty = BindableProperty.Create(nameof(Foo), typeof(int), typeof(CustomButton));

    public int Foo
    {
        get => (int)GetValue(FooProperty);
        set => SetValue(FooProperty, value);
    }
    
}