using NPlug;

namespace Overdrive.Library;

public class OverdriveModel : AudioProcessorModel
{
    public AudioParameter Gain { get; }
    public AudioParameter Overdrive { get; set; }



    public OverdriveModel() : base("Overdrive")
    {
        this.AddByPassParameter();

        this.Gain = this.AddParameter(new AudioParameter("Gain", units: "db", defaultNormalizedValue: 0.0f));
        this.Overdrive = this.AddParameter(new AudioParameter("Overdrive", defaultNormalizedValue: 0.0f));
    }
}
