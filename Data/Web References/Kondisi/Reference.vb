﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.34209
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Xml.Serialization

'
'This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.34209.
'
Namespace Kondisi
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Web.Services.WebServiceBindingAttribute(Name:="KondisiSoap", [Namespace]:="http://tempuri.org/")>  _
    Partial Public Class Kondisi
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol
        
        Private insertOperationCompleted As System.Threading.SendOrPostCallback
        
        Private updateOperationCompleted As System.Threading.SendOrPostCallback
        
        Private deleteOperationCompleted As System.Threading.SendOrPostCallback
        
        Private selectallOperationCompleted As System.Threading.SendOrPostCallback
        
        Private databaseOperationCompleted As System.Threading.SendOrPostCallback
        
        Private quartzOperationCompleted As System.Threading.SendOrPostCallback
        
        Private useDefaultCredentialsSetExplicitly As Boolean
        
        '''<remarks/>
        Public Sub New()
            MyBase.New
            Me.Url = Global.Data.My.MySettings.Default.Data_Kondisi_Kondisi
            If (Me.IsLocalFileSystemWebService(Me.Url) = true) Then
                Me.UseDefaultCredentials = true
                Me.useDefaultCredentialsSetExplicitly = false
            Else
                Me.useDefaultCredentialsSetExplicitly = true
            End If
        End Sub
        
        Public Shadows Property Url() As String
            Get
                Return MyBase.Url
            End Get
            Set
                If (((Me.IsLocalFileSystemWebService(MyBase.Url) = true)  _
                            AndAlso (Me.useDefaultCredentialsSetExplicitly = false))  _
                            AndAlso (Me.IsLocalFileSystemWebService(value) = false)) Then
                    MyBase.UseDefaultCredentials = false
                End If
                MyBase.Url = value
            End Set
        End Property
        
        Public Shadows Property UseDefaultCredentials() As Boolean
            Get
                Return MyBase.UseDefaultCredentials
            End Get
            Set
                MyBase.UseDefaultCredentials = value
                Me.useDefaultCredentialsSetExplicitly = true
            End Set
        End Property
        
        '''<remarks/>
        Public Event insertCompleted As insertCompletedEventHandler
        
        '''<remarks/>
        Public Event updateCompleted As updateCompletedEventHandler
        
        '''<remarks/>
        Public Event deleteCompleted As deleteCompletedEventHandler
        
        '''<remarks/>
        Public Event selectallCompleted As selectallCompletedEventHandler
        
        '''<remarks/>
        Public Event databaseCompleted As databaseCompletedEventHandler
        
        '''<remarks/>
        Public Event quartzCompleted As quartzCompletedEventHandler
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/insert", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function insert(ByVal ds As System.Data.DataSet) As Boolean
            Dim results() As Object = Me.Invoke("insert", New Object() {ds})
            Return CType(results(0),Boolean)
        End Function
        
        '''<remarks/>
        Public Overloads Sub insertAsync(ByVal ds As System.Data.DataSet)
            Me.insertAsync(ds, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub insertAsync(ByVal ds As System.Data.DataSet, ByVal userState As Object)
            If (Me.insertOperationCompleted Is Nothing) Then
                Me.insertOperationCompleted = AddressOf Me.OninsertOperationCompleted
            End If
            Me.InvokeAsync("insert", New Object() {ds}, Me.insertOperationCompleted, userState)
        End Sub
        
        Private Sub OninsertOperationCompleted(ByVal arg As Object)
            If (Not (Me.insertCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent insertCompleted(Me, New insertCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/update", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Sub update(ByVal ds As System.Data.DataSet)
            Me.Invoke("update", New Object() {ds})
        End Sub
        
        '''<remarks/>
        Public Overloads Sub updateAsync(ByVal ds As System.Data.DataSet)
            Me.updateAsync(ds, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub updateAsync(ByVal ds As System.Data.DataSet, ByVal userState As Object)
            If (Me.updateOperationCompleted Is Nothing) Then
                Me.updateOperationCompleted = AddressOf Me.OnupdateOperationCompleted
            End If
            Me.InvokeAsync("update", New Object() {ds}, Me.updateOperationCompleted, userState)
        End Sub
        
        Private Sub OnupdateOperationCompleted(ByVal arg As Object)
            If (Not (Me.updateCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent updateCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/delete", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Sub delete(ByVal ds As System.Data.DataSet)
            Me.Invoke("delete", New Object() {ds})
        End Sub
        
        '''<remarks/>
        Public Overloads Sub deleteAsync(ByVal ds As System.Data.DataSet)
            Me.deleteAsync(ds, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub deleteAsync(ByVal ds As System.Data.DataSet, ByVal userState As Object)
            If (Me.deleteOperationCompleted Is Nothing) Then
                Me.deleteOperationCompleted = AddressOf Me.OndeleteOperationCompleted
            End If
            Me.InvokeAsync("delete", New Object() {ds}, Me.deleteOperationCompleted, userState)
        End Sub
        
        Private Sub OndeleteOperationCompleted(ByVal arg As Object)
            If (Not (Me.deleteCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent deleteCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/selectall", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function selectall() As System.Xml.XmlNode
            Dim results() As Object = Me.Invoke("selectall", New Object(-1) {})
            Return CType(results(0),System.Xml.XmlNode)
        End Function
        
        '''<remarks/>
        Public Overloads Sub selectallAsync()
            Me.selectallAsync(Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub selectallAsync(ByVal userState As Object)
            If (Me.selectallOperationCompleted Is Nothing) Then
                Me.selectallOperationCompleted = AddressOf Me.OnselectallOperationCompleted
            End If
            Me.InvokeAsync("selectall", New Object(-1) {}, Me.selectallOperationCompleted, userState)
        End Sub
        
        Private Sub OnselectallOperationCompleted(ByVal arg As Object)
            If (Not (Me.selectallCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent selectallCompleted(Me, New selectallCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/database", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Sub database()
            Me.Invoke("database", New Object(-1) {})
        End Sub
        
        '''<remarks/>
        Public Overloads Sub databaseAsync()
            Me.databaseAsync(Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub databaseAsync(ByVal userState As Object)
            If (Me.databaseOperationCompleted Is Nothing) Then
                Me.databaseOperationCompleted = AddressOf Me.OndatabaseOperationCompleted
            End If
            Me.InvokeAsync("database", New Object(-1) {}, Me.databaseOperationCompleted, userState)
        End Sub
        
        Private Sub OndatabaseOperationCompleted(ByVal arg As Object)
            If (Not (Me.databaseCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent databaseCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/quartz", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Sub quartz()
            Me.Invoke("quartz", New Object(-1) {})
        End Sub
        
        '''<remarks/>
        Public Overloads Sub quartzAsync()
            Me.quartzAsync(Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub quartzAsync(ByVal userState As Object)
            If (Me.quartzOperationCompleted Is Nothing) Then
                Me.quartzOperationCompleted = AddressOf Me.OnquartzOperationCompleted
            End If
            Me.InvokeAsync("quartz", New Object(-1) {}, Me.quartzOperationCompleted, userState)
        End Sub
        
        Private Sub OnquartzOperationCompleted(ByVal arg As Object)
            If (Not (Me.quartzCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent quartzCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        Public Shadows Sub CancelAsync(ByVal userState As Object)
            MyBase.CancelAsync(userState)
        End Sub
        
        Private Function IsLocalFileSystemWebService(ByVal url As String) As Boolean
            If ((url Is Nothing)  _
                        OrElse (url Is String.Empty)) Then
                Return false
            End If
            Dim wsUri As System.Uri = New System.Uri(url)
            If ((wsUri.Port >= 1024)  _
                        AndAlso (String.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) = 0)) Then
                Return true
            End If
            Return false
        End Function
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")>  _
    Public Delegate Sub insertCompletedEventHandler(ByVal sender As Object, ByVal e As insertCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class insertCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As Boolean
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),Boolean)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")>  _
    Public Delegate Sub updateCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")>  _
    Public Delegate Sub deleteCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")>  _
    Public Delegate Sub selectallCompletedEventHandler(ByVal sender As Object, ByVal e As selectallCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class selectallCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As System.Xml.XmlNode
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),System.Xml.XmlNode)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")>  _
    Public Delegate Sub databaseCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")>  _
    Public Delegate Sub quartzCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
End Namespace
