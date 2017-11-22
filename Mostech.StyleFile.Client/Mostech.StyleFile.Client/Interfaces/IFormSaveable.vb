
Imports Mostech.StyleFile.Entity

Public Interface IFormSaveable

    Sub _save()
    Sub _setSaveState(ByVal bIsSaveable As Boolean)
    Sub _isDirty(ByVal b As Boolean)
    'Sub _instantiateFromUI(ByVal bValues As Boolean)

    Function _isRequiredFieldsFilled() As Boolean
    Function _isInputValidated(ByVal entity As Entity.Entity) As Boolean

End Interface

