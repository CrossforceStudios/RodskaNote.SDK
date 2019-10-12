﻿using Catel.Data;
using Catel.IoC;
using Catel.MVVM;
using Catel.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xceed.Wpf.AvalonDock.Layout;

namespace RodskaNote.Models
{
    /// <summary>
    /// An abstract class used for storing and implementing world design element types in RodskaNote.
    /// </summary>
    public abstract class WorldDocument : SavableModelBase<WorldDocument>
    {
        /// <summary>
        /// The heading of the document as displayed in the UI.
        /// </summary>
        public string Title
        {
            get { return GetValue<string>(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }
        [Import]
        public static readonly PropertyData TitleProperty = RegisterProperty("Title", typeof(string), () => "Untitled");

        public string DisplayType { get; set; } = "World Document";
        public string Type
        {
            get { return GetValue<string>(TypeProperty); }
            set { SetValue(TypeProperty, value);  }
        }
        public static string GetTypeString()
        {
            return "WorldDocument";
        }
        [Import]
        public static readonly PropertyData TypeProperty = RegisterProperty("Type", typeof(string), () => "WorldDocument");


#pragma warning disable IDE0060 // Remove unused parameter
        [Export]
        public static void InitializeDocumentType(IUIVisualizerService uiVisualizerService, IViewModelLocator viewModelLocator)
        {
#pragma warning restore IDE0060 // Remove unused parameter
        
        }
        public abstract void SaveDocumentAs(ITypeFactory factory);
        public abstract void Compile();

        public bool IsCanceled
        {
            get;
            set;
        }
        public static event EventHandler<UICompletedEventArgs> DocumentAdded;

        public string CompilationResult { get; set; }
        [Export]
        public static void CreateEditor(LayoutDocument document)
        {
            
        }

        [Export]
        public static async Task<bool?> GetFromPrompt(IUIVisualizerService _uiVisualizerService, ViewModelBase viewModel)
        {
            var result = await _uiVisualizerService.ShowAsync(viewModel, DocumentAdded) ?? false;
            return result;
        }
        [Export]

        public static void PopulateEditor(Dictionary<string, Dictionary<string, object>> details) { }
    }
}
