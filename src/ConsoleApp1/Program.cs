
using Sample;
using static Sample.SendState;

SendState x = new Ready();
x = new Send();
x = new Sending();
x = new Sent();


var ret = x switch
{
    Ready => "Ready",
    Send => "Send",
    _ => ""
};

Console.WriteLine($"{ret}");
