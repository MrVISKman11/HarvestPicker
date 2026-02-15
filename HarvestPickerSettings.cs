using ExileCore.Shared.Interfaces;
using ExileCore.Shared.Nodes;
using Newtonsoft.Json;
using SharpDX;

namespace HarvestPicker;

public class HarvestPickerSettings : ISettings
{
    //Mandatory setting to allow enabling/disabling your plugin
    public ToggleNode Enable { get; set; } = new ToggleNode(false);

    public ListNode League { get; set; } = new ListNode() { Value = "Necropolis" };

    [JsonIgnore]
    public ButtonNode ReloadPrices { get; set; } = new ButtonNode();
    public ToggleNode DrawRotationOnMap { get; set; } = new ToggleNode(true);

    public ColorNode BadColor { get; set; } = new ColorNode(Color.Red);
    public ColorNode NeutralColor { get; set; } = new ColorNode(Color.Yellow);
    public ColorNode GoodColor { get; set; } = new ColorNode(Color.Green);

    public RangeNode<int> SeedsPerT1Plant { get; set; } = new RangeNode<int>(0, 0, 300);
    public RangeNode<int> SeedsPerT2Plant { get; set; } = new RangeNode<int>(5, 0, 300);
    public RangeNode<int> SeedsPerT3Plant { get; set; } = new RangeNode<int>(100, 0, 300);
    public RangeNode<int> SeedsPerT4Plant { get; set; } = new RangeNode<int>(500, 0, 900);
    public RangeNode<float> T4PlantWhiteSeedChance { get; set; } = new RangeNode<float>(0.1f, 0, 1f);

    public RangeNode<float> CropRotationT1UpgradeChance { get; set; } = new RangeNode<float>(0.33f, 0, 1f);
    public RangeNode<float> CropRotationT2UpgradeChance { get; set; } = new RangeNode<float>(0.33f, 0, 1f);
    public RangeNode<float> CropRotationT3UpgradeChance { get; set; } = new RangeNode<float>(0.33f, 0, 1f);

    public ToggleNode UseManualRates { get; set; } = new ToggleNode(false);
    public RangeNode<float> DivineOrbPrice { get; set; } = new RangeNode<float>(150, 1, 10000);
    public RangeNode<float> VividLifeforcePerDivine { get; set; } = new RangeNode<float>(5000, 1, 50000);
    public RangeNode<float> PrimalLifeforcePerDivine { get; set; } = new RangeNode<float>(5000, 1, 50000);
    public RangeNode<float> WildLifeforcePerDivine { get; set; } = new RangeNode<float>(5000, 1, 50000);
    public RangeNode<float> SacredLifeforcePerDivine { get; set; } = new RangeNode<float>(1, 1, 100);
}
