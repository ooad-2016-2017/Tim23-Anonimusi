﻿#pragma checksum "C:\Users\Korisnik\Documents\Visual Studio 2015\Projects\Projekat\Projekat\Kino\Views\ListaKina.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "56746F138BD8B825C78C5D6B6206D1E6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Projekat.Kino.Views
{
    partial class ListaKina : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.listaKina = (global::Windows.UI.Xaml.Controls.ListBox)(target);
                }
                break;
            case 2:
                {
                    this.image = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 3:
                {
                    this.obrisi = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 34 "..\..\..\..\Kino\Views\ListaKina.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.obrisi).Click += this.obrisi_Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.edit = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 35 "..\..\..\..\Kino\Views\ListaKina.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.edit).Click += this.edit_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.dodaj = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 36 "..\..\..\..\Kino\Views\ListaKina.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.dodaj).Click += this.dodaj_Click;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

