using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml;

//https://go.microsoft.com/fwlink/?LinkId=234236 �Ͻ����ˡ��û��ؼ�����ģ��

namespace HyPlayer.Controls;

public sealed partial class SelectableTextBox : UserControl
{
    public static readonly DependencyProperty SelectableProperty = DependencyProperty.Register(
        nameof(Selectable), typeof(bool), typeof(SelectableTextBox), new PropertyMetadata(true));

    public static readonly DependencyProperty TextProperty = DependencyProperty.Register(
        nameof(Text), typeof(string), typeof(SelectableTextBox), new PropertyMetadata(default(string)));

    public static readonly DependencyProperty MaxLinesProperty = DependencyProperty.Register(
        nameof(MaxLines), typeof(int), typeof(SelectableTextBox), new PropertyMetadata(default(int)));

    public static readonly DependencyProperty TextWrappingProperty = DependencyProperty.Register(
        nameof(TextWrapping), typeof(TextWrapping), typeof(SelectableTextBox), new PropertyMetadata(default(TextWrapping)));

    public SelectableTextBox()
    {
        InitializeComponent();
    }

    public bool Selectable
    {
        get => (bool)GetValue(SelectableProperty);
        set => SetValue(SelectableProperty, value);
    }

    public string Text
    {
        get => (string)GetValue(TextProperty);
        set => SetValue(TextProperty, value);
    }

    public int MaxLines
    {
        get => (int)GetValue(MaxLinesProperty);
        set => SetValue(MaxLinesProperty, value);
    }

    public TextWrapping TextWrapping
    {
        get => (TextWrapping)GetValue(TextWrappingProperty);
        set => SetValue(TextWrappingProperty, value);
    }
}