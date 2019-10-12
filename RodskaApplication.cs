using Catel.IoC;
using Catel.MVVM;
using Catel.MVVM.Views;
using Catel.Services;
using NodeNetwork.ViewModels;
using RodskaNote.Attributes;
using RodskaNote.Models;
using RodskaNote.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Annotations;

namespace RodskaNote
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public class RodskaApplication : Application
    {
        public string Version { get; set; } = "Version 0.1";
        public ObservableCollection<CreativeDocumentRepresentation> InteractionModels { get; set; } = new ObservableCollection<CreativeDocumentRepresentation>();
        public IServiceLocator serviceLocator;
        public IUIVisualizerService uiVisualizerService;
        public IViewModelLocator viewModelLocator;
        public MasterViewModel currentMainVM;
        public List<Type> nodeTypes = new List<Type>();
        public RodskaApplication()
        {
            serviceLocator = ServiceLocator.Default;
        }
    }
}
