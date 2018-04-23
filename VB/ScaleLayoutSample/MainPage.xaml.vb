Imports Microsoft.VisualBasic
Imports System
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Threading

Namespace ScaleLayoutSample
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()

			  DataContext = New ClockViewModel()
		End Sub
	End Class

	Public Class ClockViewModel
		Inherits DependencyObject
		Public Shared ReadOnly HourProperty As DependencyProperty = DependencyProperty.Register("Hour", GetType(Double), GetType(ClockViewModel), New PropertyMetadata(0.0))
		Public Shared ReadOnly MinuteProperty As DependencyProperty = DependencyProperty.Register("Minute", GetType(Double), GetType(ClockViewModel), New PropertyMetadata(0.0))
		Public Shared ReadOnly SecondProperty As DependencyProperty = DependencyProperty.Register("Second", GetType(Double), GetType(ClockViewModel), New PropertyMetadata(0.0))
		Public Shared ReadOnly DayOfWeekProperty As DependencyProperty = DependencyProperty.Register("DayOfWeek", GetType(Double), GetType(ClockViewModel), New PropertyMetadata(0.0))
		Public Shared ReadOnly DayOfMonthProperty As DependencyProperty = DependencyProperty.Register("DayOfMonth", GetType(Double), GetType(ClockViewModel), New PropertyMetadata(0.0))
		Public Shared ReadOnly MonthOfYearProperty As DependencyProperty = DependencyProperty.Register("MonthOfYear", GetType(Double), GetType(ClockViewModel), New PropertyMetadata(0.0))

		Public Property Hour() As Double
			Get
				Return CDbl(GetValue(HourProperty))
			End Get
			Set(ByVal value As Double)
				SetValue(HourProperty, value)
			End Set
		End Property

		Public Property Minute() As Double
			Get
				Return CDbl(GetValue(MinuteProperty))
			End Get
			Set(ByVal value As Double)
				SetValue(MinuteProperty, value)
			End Set
		End Property

		Public Property Second() As Double
			Get
				Return CDbl(GetValue(SecondProperty))
			End Get
			Set(ByVal value As Double)
				SetValue(SecondProperty, value)
			End Set
		End Property

		Public Property DayOfWeek() As Double
			Get
				Return CDbl(GetValue(DayOfWeekProperty))
			End Get
			Set(ByVal value As Double)
				SetValue(DayOfWeekProperty, value)
			End Set
		End Property

		Public Property DayOfMonth() As Double
			Get
				Return CInt(Fix(GetValue(DayOfMonthProperty)))
			End Get
			Set(ByVal value As Double)
				SetValue(DayOfMonthProperty, value)
			End Set
		End Property

		Public Property MonthOfYear() As Double
			Get
				Return CDbl(GetValue(MonthOfYearProperty))
			End Get
			Set(ByVal value As Double)
				SetValue(MonthOfYearProperty, value)
			End Set
		End Property

		Private ReadOnly timer As New DispatcherTimer()

		Public Sub New()
			AddHandler timer.Tick, AddressOf OnTimedEvent
			timer.Start()
			Update()
		End Sub

		Private Sub Update()
			Dim currentDate As DateTime = DateTime.Now

			Second = (currentDate.Second / 60.0) * 12
			Minute = ((currentDate.Minute + currentDate.Second / 60.0) / 60.0) * 12
			Hour = (currentDate.Hour Mod 12) + currentDate.Minute / 60.0

			DayOfMonth = currentDate.Day
			DayOfWeek = CInt(Fix(currentDate.DayOfWeek))
			MonthOfYear = currentDate.Month
		End Sub

		Private Sub OnTimedEvent(ByVal source As Object, ByVal e As EventArgs)
			Update()
		End Sub
	End Class
End Namespace





