using Dunet;
namespace Sample;

[Union]
public partial record SendState
{
    public partial record Ready();
    public partial record Send();
    public partial record Sending();
    public partial record Sent();
}
