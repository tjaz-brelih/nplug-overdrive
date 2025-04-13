using NPlug;

namespace Overdrive.Library;

public class OverdriveProcessor : AudioProcessor<OverdriveModel>
{
    public static readonly Guid ClassId = new("d7e76c1a-df07-47a0-8d1e-8e5a421135cd");


    public override Guid ControllerClassId => OverdriveController.ClassId;



    public OverdriveProcessor() : base(AudioSampleSizeSupport.Float32)
    {

    }



    protected override bool Initialize(AudioHostApplication host)
    {
        this.AddDefaultStereoAudioInput();
        this.AddDefaultStereoAudioOutput();

        return true;
    }


    protected override void OnActivate(bool isActive)
    {

    }

    protected override void ProcessMain(in AudioProcessData data)
    {
        
    }
}
