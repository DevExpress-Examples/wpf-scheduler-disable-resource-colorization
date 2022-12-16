Imports System.Collections.ObjectModel
Imports DevExpress.Mvvm
Imports DXSample.Data

Namespace DXSample.ViewModels

    Public Class SchedulingViewModel
        Inherits ViewModelBase

        Public Sub New()
            Dim data As SportChannelsDataHelper = New SportChannelsDataHelper(2)
            SportEvents = data.Events
            SportChannels = data.Channels
            SportGroups = data.Groups
        End Sub

        Public Property SportEvents As ObservableCollection(Of SportEvent)
            Get
                Return GetValue(Of ObservableCollection(Of SportEvent))()
            End Get

            Set(ByVal value As ObservableCollection(Of SportEvent))
                SetValue(value)
            End Set
        End Property

        Public Property SportChannels As ObservableCollection(Of SportChannel)
            Get
                Return GetValue(Of ObservableCollection(Of SportChannel))()
            End Get

            Set(ByVal value As ObservableCollection(Of SportChannel))
                SetValue(value)
            End Set
        End Property

        Public Property SportGroups As ObservableCollection(Of SportGroup)
            Get
                Return GetValue(Of ObservableCollection(Of SportGroup))()
            End Get

            Set(ByVal value As ObservableCollection(Of SportGroup))
                SetValue(value)
            End Set
        End Property
    End Class
End Namespace
