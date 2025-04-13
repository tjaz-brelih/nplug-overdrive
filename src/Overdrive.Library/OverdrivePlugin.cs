using System.Runtime.CompilerServices;
using NPlug;


namespace Overdrive.Library;

public static class OverdrivePlugin
{
    public static AudioPluginFactory GetFactory()
    {
        var factory = new AudioPluginFactory(new("tjazbrelih", "https://github.com/tjaz-brelih", "tjaz.brelih@gmail.com"));

        factory.RegisterPlugin<OverdriveProcessor>(new(OverdriveProcessor.ClassId, "Overdrive", AudioProcessorCategory.EffectDistortion));
        factory.RegisterPlugin<OverdriveController>(new(OverdriveController.ClassId, "Overdrive Controller"));

        return factory;
    }


    [ModuleInitializer]
    internal static void ExportThisPlugin()
    {
        AudioPluginFactoryExporter.Instance = GetFactory();
    }
}
