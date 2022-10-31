<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Información
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IdLabel As System.Windows.Forms.Label
        Dim Nombre_Label As System.Windows.Forms.Label
        Dim Apellidos_Label As System.Windows.Forms.Label
        Dim Celular_Label As System.Windows.Forms.Label
        Dim Correo_Label As System.Windows.Forms.Label
        Dim Cédula_Label As System.Windows.Forms.Label
        Dim Dirección_Label As System.Windows.Forms.Label
        Dim Nombre_de_la_unidad_Label As System.Windows.Forms.Label
        Dim Departamento_Label As System.Windows.Forms.Label
        Dim Municipio_Label As System.Windows.Forms.Label
        Dim Barrio_Label As System.Windows.Forms.Label
        Dim _Autorizo_el_tratamiento_de_mis_datos__Label As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Información))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Bases_de_datosDataSet = New Proyecto_Ingenieria_Civil.Bases_de_datosDataSet()
        Me.Tabla1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tabla1TableAdapter = New Proyecto_Ingenieria_Civil.Bases_de_datosDataSetTableAdapters.Tabla1TableAdapter()
        Me.TableAdapterManager = New Proyecto_Ingenieria_Civil.Bases_de_datosDataSetTableAdapters.TableAdapterManager()
        Me.Tabla1BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tabla1BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.Nombre_TextBox = New System.Windows.Forms.TextBox()
        Me.Apellidos_TextBox = New System.Windows.Forms.TextBox()
        Me.Celular_TextBox = New System.Windows.Forms.TextBox()
        Me.Correo_TextBox = New System.Windows.Forms.TextBox()
        Me.Cédula_TextBox = New System.Windows.Forms.TextBox()
        Me.Dirección_TextBox = New System.Windows.Forms.TextBox()
        Me.Nombre_de_la_unidad_TextBox = New System.Windows.Forms.TextBox()
        Me.Departamento_TextBox = New System.Windows.Forms.TextBox()
        Me.Municipio_TextBox = New System.Windows.Forms.TextBox()
        Me.Barrio_TextBox = New System.Windows.Forms.TextBox()
        Me._Autorizo_el_tratamiento_de_mis_datos__CheckBox = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        IdLabel = New System.Windows.Forms.Label()
        Nombre_Label = New System.Windows.Forms.Label()
        Apellidos_Label = New System.Windows.Forms.Label()
        Celular_Label = New System.Windows.Forms.Label()
        Correo_Label = New System.Windows.Forms.Label()
        Cédula_Label = New System.Windows.Forms.Label()
        Dirección_Label = New System.Windows.Forms.Label()
        Nombre_de_la_unidad_Label = New System.Windows.Forms.Label()
        Departamento_Label = New System.Windows.Forms.Label()
        Municipio_Label = New System.Windows.Forms.Label()
        Barrio_Label = New System.Windows.Forms.Label()
        _Autorizo_el_tratamiento_de_mis_datos__Label = New System.Windows.Forms.Label()
        CType(Me.Bases_de_datosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tabla1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tabla1BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tabla1BindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(12, 33)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(19, 13)
        IdLabel.TabIndex = 26
        IdLabel.Text = "Id:"
        AddHandler IdLabel.Click, AddressOf Me.IdLabel_Click
        '
        'Nombre_Label
        '
        Nombre_Label.AutoSize = True
        Nombre_Label.Location = New System.Drawing.Point(12, 59)
        Nombre_Label.Name = "Nombre_Label"
        Nombre_Label.Size = New System.Drawing.Size(47, 13)
        Nombre_Label.TabIndex = 28
        Nombre_Label.Text = "Nombre:"
        AddHandler Nombre_Label.Click, AddressOf Me.Nombre_Label_Click
        '
        'Apellidos_Label
        '
        Apellidos_Label.AutoSize = True
        Apellidos_Label.Location = New System.Drawing.Point(12, 85)
        Apellidos_Label.Name = "Apellidos_Label"
        Apellidos_Label.Size = New System.Drawing.Size(52, 13)
        Apellidos_Label.TabIndex = 30
        Apellidos_Label.Text = "Apellidos:"
        AddHandler Apellidos_Label.Click, AddressOf Me.Apellidos_Label_Click
        '
        'Celular_Label
        '
        Celular_Label.AutoSize = True
        Celular_Label.Location = New System.Drawing.Point(12, 111)
        Celular_Label.Name = "Celular_Label"
        Celular_Label.Size = New System.Drawing.Size(42, 13)
        Celular_Label.TabIndex = 32
        Celular_Label.Text = "Celular:"
        AddHandler Celular_Label.Click, AddressOf Me.Celular_Label_Click
        '
        'Correo_Label
        '
        Correo_Label.AutoSize = True
        Correo_Label.Location = New System.Drawing.Point(12, 137)
        Correo_Label.Name = "Correo_Label"
        Correo_Label.Size = New System.Drawing.Size(41, 13)
        Correo_Label.TabIndex = 34
        Correo_Label.Text = "Correo:"
        AddHandler Correo_Label.Click, AddressOf Me.Correo_Label_Click
        '
        'Cédula_Label
        '
        Cédula_Label.AutoSize = True
        Cédula_Label.Location = New System.Drawing.Point(12, 163)
        Cédula_Label.Name = "Cédula_Label"
        Cédula_Label.Size = New System.Drawing.Size(43, 13)
        Cédula_Label.TabIndex = 36
        Cédula_Label.Text = "Cédula:"
        AddHandler Cédula_Label.Click, AddressOf Me.Cédula_Label_Click
        '
        'Dirección_Label
        '
        Dirección_Label.AutoSize = True
        Dirección_Label.Location = New System.Drawing.Point(12, 189)
        Dirección_Label.Name = "Dirección_Label"
        Dirección_Label.Size = New System.Drawing.Size(55, 13)
        Dirección_Label.TabIndex = 38
        Dirección_Label.Text = "Dirección:"
        AddHandler Dirección_Label.Click, AddressOf Me.Dirección_Label_Click
        '
        'Nombre_de_la_unidad_Label
        '
        Nombre_de_la_unidad_Label.AutoSize = True
        Nombre_de_la_unidad_Label.Location = New System.Drawing.Point(12, 215)
        Nombre_de_la_unidad_Label.Name = "Nombre_de_la_unidad_Label"
        Nombre_de_la_unidad_Label.Size = New System.Drawing.Size(108, 13)
        Nombre_de_la_unidad_Label.TabIndex = 40
        Nombre_de_la_unidad_Label.Text = "Nombre de la unidad:"
        AddHandler Nombre_de_la_unidad_Label.Click, AddressOf Me.Nombre_de_la_unidad_Label_Click
        '
        'Departamento_Label
        '
        Departamento_Label.AutoSize = True
        Departamento_Label.Location = New System.Drawing.Point(12, 241)
        Departamento_Label.Name = "Departamento_Label"
        Departamento_Label.Size = New System.Drawing.Size(77, 13)
        Departamento_Label.TabIndex = 42
        Departamento_Label.Text = "Departamento:"
        AddHandler Departamento_Label.Click, AddressOf Me.Departamento_Label_Click
        '
        'Municipio_Label
        '
        Municipio_Label.AutoSize = True
        Municipio_Label.Location = New System.Drawing.Point(12, 267)
        Municipio_Label.Name = "Municipio_Label"
        Municipio_Label.Size = New System.Drawing.Size(55, 13)
        Municipio_Label.TabIndex = 44
        Municipio_Label.Text = "Municipio:"
        AddHandler Municipio_Label.Click, AddressOf Me.Municipio_Label_Click
        '
        'Barrio_Label
        '
        Barrio_Label.AutoSize = True
        Barrio_Label.Location = New System.Drawing.Point(12, 293)
        Barrio_Label.Name = "Barrio_Label"
        Barrio_Label.Size = New System.Drawing.Size(37, 13)
        Barrio_Label.TabIndex = 46
        Barrio_Label.Text = "Barrio:"
        AddHandler Barrio_Label.Click, AddressOf Me.Barrio_Label_Click
        '
        '_Autorizo_el_tratamiento_de_mis_datos__Label
        '
        _Autorizo_el_tratamiento_de_mis_datos__Label.AutoSize = True
        _Autorizo_el_tratamiento_de_mis_datos__Label.Location = New System.Drawing.Point(12, 321)
        _Autorizo_el_tratamiento_de_mis_datos__Label.Name = "_Autorizo_el_tratamiento_de_mis_datos__Label"
        _Autorizo_el_tratamiento_de_mis_datos__Label.Size = New System.Drawing.Size(188, 13)
        _Autorizo_el_tratamiento_de_mis_datos__Label.TabIndex = 48
        _Autorizo_el_tratamiento_de_mis_datos__Label.Text = "¿Autorizo el tratamiento de mis datos?:"
        AddHandler _Autorizo_el_tratamiento_de_mis_datos__Label.Click, AddressOf Me._Autorizo_el_tratamiento_de_mis_datos__Label_Click
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Por favor ingrese su información"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(219, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(401, 13)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Se le invita a contestar estas preguntas en base a la situación actual de su vive" &
    "nda" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Bases_de_datosDataSet
        '
        Me.Bases_de_datosDataSet.DataSetName = "Bases_de_datosDataSet"
        Me.Bases_de_datosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tabla1BindingSource
        '
        Me.Tabla1BindingSource.DataMember = "Tabla1"
        Me.Tabla1BindingSource.DataSource = Me.Bases_de_datosDataSet
        '
        'Tabla1TableAdapter
        '
        Me.Tabla1TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Tabla1TableAdapter = Me.Tabla1TableAdapter
        Me.TableAdapterManager.UpdateOrder = Proyecto_Ingenieria_Civil.Bases_de_datosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tabla1BindingNavigator
        '
        Me.Tabla1BindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tabla1BindingNavigator.BindingSource = Me.Tabla1BindingSource
        Me.Tabla1BindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tabla1BindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tabla1BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Tabla1BindingNavigatorSaveItem})
        Me.Tabla1BindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tabla1BindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tabla1BindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tabla1BindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tabla1BindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tabla1BindingNavigator.Name = "Tabla1BindingNavigator"
        Me.Tabla1BindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tabla1BindingNavigator.Size = New System.Drawing.Size(454, 25)
        Me.Tabla1BindingNavigator.TabIndex = 26
        Me.Tabla1BindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Tabla1BindingNavigatorSaveItem
        '
        Me.Tabla1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tabla1BindingNavigatorSaveItem.Image = CType(resources.GetObject("Tabla1BindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tabla1BindingNavigatorSaveItem.Name = "Tabla1BindingNavigatorSaveItem"
        Me.Tabla1BindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Tabla1BindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tabla1BindingSource, "Id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(206, 30)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(104, 20)
        Me.IdTextBox.TabIndex = 27
        '
        'Nombre_TextBox
        '
        Me.Nombre_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tabla1BindingSource, "Nombre:", True))
        Me.Nombre_TextBox.Location = New System.Drawing.Point(206, 56)
        Me.Nombre_TextBox.Name = "Nombre_TextBox"
        Me.Nombre_TextBox.Size = New System.Drawing.Size(104, 20)
        Me.Nombre_TextBox.TabIndex = 29
        '
        'Apellidos_TextBox
        '
        Me.Apellidos_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tabla1BindingSource, "Apellidos:", True))
        Me.Apellidos_TextBox.Location = New System.Drawing.Point(206, 82)
        Me.Apellidos_TextBox.Name = "Apellidos_TextBox"
        Me.Apellidos_TextBox.Size = New System.Drawing.Size(104, 20)
        Me.Apellidos_TextBox.TabIndex = 31
        '
        'Celular_TextBox
        '
        Me.Celular_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tabla1BindingSource, "Celular:", True))
        Me.Celular_TextBox.Location = New System.Drawing.Point(206, 108)
        Me.Celular_TextBox.Name = "Celular_TextBox"
        Me.Celular_TextBox.Size = New System.Drawing.Size(104, 20)
        Me.Celular_TextBox.TabIndex = 33
        '
        'Correo_TextBox
        '
        Me.Correo_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tabla1BindingSource, "Correo:", True))
        Me.Correo_TextBox.Location = New System.Drawing.Point(206, 134)
        Me.Correo_TextBox.Name = "Correo_TextBox"
        Me.Correo_TextBox.Size = New System.Drawing.Size(104, 20)
        Me.Correo_TextBox.TabIndex = 35
        '
        'Cédula_TextBox
        '
        Me.Cédula_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tabla1BindingSource, "Cédula:", True))
        Me.Cédula_TextBox.Location = New System.Drawing.Point(206, 160)
        Me.Cédula_TextBox.Name = "Cédula_TextBox"
        Me.Cédula_TextBox.Size = New System.Drawing.Size(104, 20)
        Me.Cédula_TextBox.TabIndex = 37
        '
        'Dirección_TextBox
        '
        Me.Dirección_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tabla1BindingSource, "Dirección:", True))
        Me.Dirección_TextBox.Location = New System.Drawing.Point(206, 186)
        Me.Dirección_TextBox.Name = "Dirección_TextBox"
        Me.Dirección_TextBox.Size = New System.Drawing.Size(104, 20)
        Me.Dirección_TextBox.TabIndex = 39
        '
        'Nombre_de_la_unidad_TextBox
        '
        Me.Nombre_de_la_unidad_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tabla1BindingSource, "Nombre de la unidad:", True))
        Me.Nombre_de_la_unidad_TextBox.Location = New System.Drawing.Point(206, 212)
        Me.Nombre_de_la_unidad_TextBox.Name = "Nombre_de_la_unidad_TextBox"
        Me.Nombre_de_la_unidad_TextBox.Size = New System.Drawing.Size(104, 20)
        Me.Nombre_de_la_unidad_TextBox.TabIndex = 41
        '
        'Departamento_TextBox
        '
        Me.Departamento_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tabla1BindingSource, "Departamento:", True))
        Me.Departamento_TextBox.Location = New System.Drawing.Point(206, 238)
        Me.Departamento_TextBox.Name = "Departamento_TextBox"
        Me.Departamento_TextBox.Size = New System.Drawing.Size(104, 20)
        Me.Departamento_TextBox.TabIndex = 43
        '
        'Municipio_TextBox
        '
        Me.Municipio_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tabla1BindingSource, "Municipio:", True))
        Me.Municipio_TextBox.Location = New System.Drawing.Point(206, 264)
        Me.Municipio_TextBox.Name = "Municipio_TextBox"
        Me.Municipio_TextBox.Size = New System.Drawing.Size(104, 20)
        Me.Municipio_TextBox.TabIndex = 45
        '
        'Barrio_TextBox
        '
        Me.Barrio_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tabla1BindingSource, "Barrio:", True))
        Me.Barrio_TextBox.Location = New System.Drawing.Point(206, 290)
        Me.Barrio_TextBox.Name = "Barrio_TextBox"
        Me.Barrio_TextBox.Size = New System.Drawing.Size(104, 20)
        Me.Barrio_TextBox.TabIndex = 47
        '
        '_Autorizo_el_tratamiento_de_mis_datos__CheckBox
        '
        Me._Autorizo_el_tratamiento_de_mis_datos__CheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Tabla1BindingSource, "¿Autorizo el tratamiento de mis datos?:", True))
        Me._Autorizo_el_tratamiento_de_mis_datos__CheckBox.Location = New System.Drawing.Point(206, 316)
        Me._Autorizo_el_tratamiento_de_mis_datos__CheckBox.Name = "_Autorizo_el_tratamiento_de_mis_datos__CheckBox"
        Me._Autorizo_el_tratamiento_de_mis_datos__CheckBox.Size = New System.Drawing.Size(104, 24)
        Me._Autorizo_el_tratamiento_de_mis_datos__CheckBox.TabIndex = 49
        Me._Autorizo_el_tratamiento_de_mis_datos__CheckBox.Text = "Autorizo"
        Me._Autorizo_el_tratamiento_de_mis_datos__CheckBox.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(351, 378)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 50
        Me.Button2.Text = "Continuar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Información
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(454, 413)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(Nombre_Label)
        Me.Controls.Add(Me.Nombre_TextBox)
        Me.Controls.Add(Apellidos_Label)
        Me.Controls.Add(Me.Apellidos_TextBox)
        Me.Controls.Add(Celular_Label)
        Me.Controls.Add(Me.Celular_TextBox)
        Me.Controls.Add(Correo_Label)
        Me.Controls.Add(Me.Correo_TextBox)
        Me.Controls.Add(Cédula_Label)
        Me.Controls.Add(Me.Cédula_TextBox)
        Me.Controls.Add(Dirección_Label)
        Me.Controls.Add(Me.Dirección_TextBox)
        Me.Controls.Add(Nombre_de_la_unidad_Label)
        Me.Controls.Add(Me.Nombre_de_la_unidad_TextBox)
        Me.Controls.Add(Departamento_Label)
        Me.Controls.Add(Me.Departamento_TextBox)
        Me.Controls.Add(Municipio_Label)
        Me.Controls.Add(Me.Municipio_TextBox)
        Me.Controls.Add(Barrio_Label)
        Me.Controls.Add(Me.Barrio_TextBox)
        Me.Controls.Add(_Autorizo_el_tratamiento_de_mis_datos__Label)
        Me.Controls.Add(Me._Autorizo_el_tratamiento_de_mis_datos__CheckBox)
        Me.Controls.Add(Me.Tabla1BindingNavigator)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Información"
        Me.Text = "Información"
        CType(Me.Bases_de_datosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tabla1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tabla1BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tabla1BindingNavigator.ResumeLayout(False)
        Me.Tabla1BindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Bases_de_datosDataSet As Bases_de_datosDataSet
    Friend WithEvents Tabla1BindingSource As BindingSource
    Friend WithEvents Tabla1TableAdapter As Bases_de_datosDataSetTableAdapters.Tabla1TableAdapter
    Friend WithEvents TableAdapterManager As Bases_de_datosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tabla1BindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Tabla1BindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents Nombre_TextBox As TextBox
    Friend WithEvents Apellidos_TextBox As TextBox
    Friend WithEvents Celular_TextBox As TextBox
    Friend WithEvents Correo_TextBox As TextBox
    Friend WithEvents Cédula_TextBox As TextBox
    Friend WithEvents Dirección_TextBox As TextBox
    Friend WithEvents Nombre_de_la_unidad_TextBox As TextBox
    Friend WithEvents Departamento_TextBox As TextBox
    Friend WithEvents Municipio_TextBox As TextBox
    Friend WithEvents Barrio_TextBox As TextBox
    Friend WithEvents _Autorizo_el_tratamiento_de_mis_datos__CheckBox As CheckBox
    Friend WithEvents Button2 As Button
End Class
