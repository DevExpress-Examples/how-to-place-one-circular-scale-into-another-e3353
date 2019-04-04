<!-- default file list -->
*Files to look at*:

* [MainPage.xaml](./CS/ScaleLayoutSample/MainPage.xaml) (VB: [MainPage.xaml](./VB/ScaleLayoutSample/MainPage.xaml))
* [MainPage.xaml.cs](./CS/ScaleLayoutSample/MainPage.xaml.cs) (VB: [MainPage.xaml.vb](./VB/ScaleLayoutSample/MainPage.xaml.vb))
<!-- default file list end -->
# How to place one circular scale into another


<p>In some cases you may need to place several circular scales into the main one.  The following example demonstrates how to create a typical watch with several scales (the main scale will show the current time, while the minor scales will show  current day, week and month).</p><p><br />
</p>


<h3>Description</h3>

<p>To place several scales inside the main one, it&#39;s necessary to create an appropriate <a href="http://msdn.microsoft.com/ru-ru/library/system.windows.controls.itemspaneltemplate.aspx"><u>ItemsPanelTemplate</u></a> object and assign it to the <a href="http://documentation.devexpress.com/#Silverlight/DevExpressXpfGaugesGaugeControlBase_ScalePanelTemplatetopic"><u>ScalePanelTemplate</u></a> property. In this example we will use the <strong>Grid </strong>panel with <strong>2</strong> rows and <strong>4</strong> columns as a custom scale panel. </p><p>After defining a custom scale panel&#39;s template, it&#39;s required to set the <a href="http://msdn.microsoft.com/ru-ru/library/system.windows.controls.grid.rowspan.aspx"><u>Grid.RowSpan</u></a> and <a href="http://msdn.microsoft.com/ru-ru/library/system.windows.controls.grid.columnspan.aspx"><u>Grid.ColumnSpan</u></a> attached properties to<strong> 2</strong> and <strong>4</strong> for the main scale, so that it occupies the entire grid area. For other circular scales, <a href="http://msdn.microsoft.com/en-us/library/cc917861(VS.95).aspx"><u>Grid.Column</u></a> and <a href="http://msdn.microsoft.com/en-us/library/cc917855(v=VS.96).aspx"><u>Grid.Row</u></a>  properties should be used to define their positions inside the grid area (and therefore, inside the main scale).</p><p><br />
<strong>Note</strong>: the declaration of the main scale in XAML is placed after declarations of all minor scales. This is done in order to paint needles of the main scale above all spindle caps of minor scales.</p><p><br />
</p>

<br/>


