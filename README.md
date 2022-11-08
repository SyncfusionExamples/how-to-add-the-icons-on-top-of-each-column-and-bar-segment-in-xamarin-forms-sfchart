# How to add the icons on top of each column/bar segment in Xamarin.Forms Chart(SfChart)

This example demonstrates how to display an icon on top of each bar and column segment that describes some information about the respective data point.

You can add icon at the top of each bar segment by setting **DataTemplate** for DataMarker with an **IValueConverter** to the [LabelTemplate](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.ChartDataMarker.html#Syncfusion_SfChart_XForms_ChartDataMarker_LabelTemplate) property.

The following code sample and output demonstrates how to add an icon at the top of each bar segment.

**XAML**
```
<ResourceDictionary>           
            <local:ChartImageConverter x:Key="imageConverter"></local:ChartImageConverter>
            <DataTemplate x:Key="icon">
                    <Image x:Name="image" Source="{Binding YValue, Converter={StaticResource imageConverter}}" WidthRequest="20" HeightRequest="20"/>
            </DataTemplate>           
</ResourceDictionary>        
    ……
<chart:ColumnSeries ItemsSource="{Binding SeriesData}" XBindingPath="XValue" YBindingPath="YValue">
                <chart:ColumnSeries.DataMarker>
                    <chart:ChartDataMarker ShowLabel="True" LabelTemplate="{StaticResource icon}">
                        <chart:ChartDataMarker.LabelStyle>
                            <chart:DataMarkerLabelStyle LabelPosition="Inner"/>
                        </chart:ChartDataMarker.LabelStyle>
                    </chart:ChartDataMarker>
                </chart:ColumnSeries.DataMarker>
</chart:ColumnSeries>
```

**C#**
```
public class ChartImageConverter : IValueConverter
{
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (System.Convert.ToDouble(value) < 0)
                return "Down.png";
            else
                return "Up.png";
        }
 
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return value;
        }
}
```

## Output:

![Chart with icons placed on top of it's bar segments in Xamarin.Forms](https://user-images.githubusercontent.com/53489303/200601031-15cd57a8-c5b0-4abe-a34d-d80e5b6a26b3.png)

KB article - [How to add the icons on top of each column/bar segment in Xamarin.Forms Chart?](https://www.syncfusion.com/kb/9313/how-to-add-the-icons-on-top-of-each-column-bar-segment-in-xamarin-forms-chart)

## <a name="troubleshooting"></a>Troubleshooting ##
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.
