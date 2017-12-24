﻿Imports Grasshopper.Kernel

Public Class Param_OwlQLearn
    Inherits GH_PersistentParam(Of GH_OwlQLearn)

    Sub New()
        MyBase.New(New GH_InstanceDescription("QLearn", "QL", "Owl QLearn", "Owl.Learning", "Params"))
    End Sub

    Public Overrides ReadOnly Property ComponentGuid As Guid
        Get
            Return New Guid("{84CF0A7D-472A-41D5-8218-6001A49F80B8}")
        End Get
    End Property

    Protected Overrides Function Prompt_Singular(ByRef value As GH_OwlQLearn) As GH_GetterResult
        Return GH_GetterResult.cancel
    End Function

    Protected Overrides Function Prompt_Plural(ByRef values As List(Of GH_OwlQLearn)) As GH_GetterResult
        Return GH_GetterResult.cancel
    End Function

    'Protected Overrides ReadOnly Property Icon As System.Drawing.Bitmap
    '    Get
    '        Return My.Resources.icon_01
    '    End Get
    'End Property

End Class
