﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.1
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("Formatter.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &amp;Cultures:.
        '''</summary>
        Friend ReadOnly Property CultureLabel() As String
            Get
                Return ResourceManager.GetString("CultureLabel", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &amp;Date and Time.
        '''</summary>
        Friend ReadOnly Property DateBoxText() As String
            Get
                Return ResourceManager.GetString("DateBoxText", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &amp;Format String:.
        '''</summary>
        Friend ReadOnly Property FormatLabel() As String
            Get
                Return ResourceManager.GetString("FormatLabel", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;Invariant&gt;.
        '''</summary>
        Friend ReadOnly Property InvariantCultureName() As String
            Get
                Return ResourceManager.GetString("InvariantCultureName", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to The value to format is not a valid date and time..
        '''</summary>
        Friend ReadOnly Property MSG_InvalidDate() As String
            Get
                Return ResourceManager.GetString("MSG_InvalidDate", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to The value to format is not a valid date and time with an offset..
        '''</summary>
        Friend ReadOnly Property MSG_InvalidDTO() As String
            Get
                Return ResourceManager.GetString("MSG_InvalidDTO", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to The value to format is not a valid floating point number..
        '''</summary>
        Friend ReadOnly Property MSG_InvalidFloat() As String
            Get
                Return ResourceManager.GetString("MSG_InvalidFloat", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to The format string is invalid..
        '''</summary>
        Friend ReadOnly Property MSG_InvalidFormat() As String
            Get
                Return ResourceManager.GetString("MSG_InvalidFormat", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to The value to format is not a valid integer number..
        '''</summary>
        Friend ReadOnly Property MSG_InvalidInteger() As String
            Get
                Return ResourceManager.GetString("MSG_InvalidInteger", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &amp;Number.
        '''</summary>
        Friend ReadOnly Property NumberBoxText() As String
            Get
                Return ResourceManager.GetString("NumberBoxText", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &amp;Display.
        '''</summary>
        Friend ReadOnly Property OKButtonText() As String
            Get
                Return ResourceManager.GetString("OKButtonText", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &amp;Result String:.
        '''</summary>
        Friend ReadOnly Property ResultLabel() As String
            Get
                Return ResourceManager.GetString("ResultLabel", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &amp;Value:.
        '''</summary>
        Friend ReadOnly Property ValueLabel() As String
            Get
                Return ResourceManager.GetString("ValueLabel", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Formatting Utility.
        '''</summary>
        Friend ReadOnly Property WindowCaption() As String
            Get
                Return ResourceManager.GetString("WindowCaption", resourceCulture)
            End Get
        End Property
    End Module
End Namespace