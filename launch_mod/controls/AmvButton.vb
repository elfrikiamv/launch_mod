Imports System

Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.ComponentModel

Namespace CustomControls.AmvControls
    Public Class AmvButton
        Inherits Button
        'Fields
        Private borderSizeField As Integer = 0
        Private borderRadiusField As Integer = 0
        Private borderColorField As Color = Color.PaleVioletRed

        'Properties
        <Category("Amv Code Advance")>
        Public Property BorderSize As Integer
            Get
                Return borderSizeField
            End Get
            Set(ByVal value As Integer)
                borderSizeField = value
                Invalidate()
            End Set
        End Property

        <Category("Amv Code Advance")>
        Public Property BorderRadius As Integer
            Get
                Return borderRadiusField
            End Get
            Set(ByVal value As Integer)
                borderRadiusField = value
                Invalidate()
            End Set
        End Property

        <Category("Amv Code Advance")>
        Public Property BorderColor As Color
            Get
                Return borderColorField
            End Get
            Set(ByVal value As Color)
                borderColorField = value
                Invalidate()
            End Set
        End Property

        <Category("Amv Code Advance")>
        Public Property BackgroundColor As Color
            Get
                Return BackColor
            End Get
            Set(ByVal value As Color)
                BackColor = value
            End Set
        End Property

        <Category("Amv Code Advance")>
        Public Property TextColor As Color
            Get
                Return ForeColor
            End Get
            Set(ByVal value As Color)
                ForeColor = value
            End Set
        End Property

        'Constructor
        Public Sub New()
            FlatStyle = FlatStyle.Flat
            FlatAppearance.BorderSize = 0
            Size = New Size(150, 40)
            BackColor = Color.MediumSlateBlue
            ForeColor = Color.White
            AddHandler Resize, New EventHandler(AddressOf Button_Resize)
        End Sub

        'Methods
        Private Function GetFigurePath(ByVal rect As Rectangle, ByVal radius As Integer) As GraphicsPath
            Dim path As GraphicsPath = New GraphicsPath()
            Dim curveSize = radius * 2F

            path.StartFigure()
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90)
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90)
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90)
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90)
            path.CloseFigure()
            Return path
        End Function

        Protected Overrides Sub OnPaint(ByVal pevent As PaintEventArgs)
            MyBase.OnPaint(pevent)


            Dim rectSurface = ClientRectangle
            Dim rectBorder = Rectangle.Inflate(rectSurface, -borderSizeField, -borderSizeField)
            Dim smoothSize = 2
            If borderSizeField > 0 Then smoothSize = borderSizeField

            If borderRadiusField > 2 Then 'Rounded button
                Using pathSurface = GetFigurePath(rectSurface, borderRadiusField)
                    Using pathBorder = GetFigurePath(rectBorder, borderRadiusField - borderSizeField)
                        Using penSurface As Pen = New Pen(Parent.BackColor, smoothSize)
                            Using penBorder As Pen = New Pen(borderColorField, borderSizeField)
                                pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias
                                'Button surface
                                Region = New Region(pathSurface)
                                'Draw surface border for HD result
                                pevent.Graphics.DrawPath(penSurface, pathSurface)

                                'Button border                    
                                'Draw control border
                                If borderSizeField >= 1 Then pevent.Graphics.DrawPath(penBorder, pathBorder)
                            End Using
                        End Using
                    End Using
                End Using 'Normal button
            Else
                pevent.Graphics.SmoothingMode = SmoothingMode.None
                'Button surface
                Region = New Region(rectSurface)
                'Button border
                If borderSizeField >= 1 Then
                    Using penBorder As Pen = New Pen(borderColorField, borderSizeField)
                        penBorder.Alignment = PenAlignment.Inset
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, Width - 1, Height - 1)
                    End Using
                End If
            End If
        End Sub
        Protected Overrides Sub OnHandleCreated(ByVal e As EventArgs)
            MyBase.OnHandleCreated(e)
            AddHandler Parent.BackColorChanged, New EventHandler(AddressOf Container_BackColorChanged)
        End Sub

        Private Sub Container_BackColorChanged(ByVal sender As Object, ByVal e As EventArgs)
            Invalidate()
        End Sub
        Private Sub Button_Resize(ByVal sender As Object, ByVal e As EventArgs)
            If borderRadiusField > Height Then borderRadiusField = Height
        End Sub
    End Class
End Namespace
