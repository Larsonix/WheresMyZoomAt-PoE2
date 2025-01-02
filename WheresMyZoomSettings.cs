using ExileCore2.Shared.Interfaces;
using ExileCore2.Shared.Nodes;

namespace WheresMyZoomAt;

public class WheresMyZoomAtSettings : ISettings
{
    public ToggleNode Enable { get; set; } = new ToggleNode(false);

    public ButtonNode EnableZoom { get; set; } = new ButtonNode();
    public ButtonNode EnableFastZoom { get; set; } = new ButtonNode();
    public ButtonNode EnableNoFog { get; set; } = new ButtonNode();
    public ButtonNode EnableNoBlackBox { get; set; } = new ButtonNode();
    public ButtonNode EnableBrightness { get; set; } = new ButtonNode();
}