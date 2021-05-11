using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Plotly.Models.Layouts.Transitions
{
    /// <summary>
    ///     The easing function used for the transition
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum EasingEnum
    {
        [EnumMember(Value = @"cubic-in-out")]
        CubicInOut = 0,

        [EnumMember(Value = @"linear")]
        Linear,

        [EnumMember(Value = @"quad")]
        Quad,

        [EnumMember(Value = @"cubic")]
        Cubic,

        [EnumMember(Value = @"sin")]
        Sin,

        [EnumMember(Value = @"exp")]
        Exp,

        [EnumMember(Value = @"circle")]
        Circle,

        [EnumMember(Value = @"elastic")]
        Elastic,

        [EnumMember(Value = @"back")]
        Back,

        [EnumMember(Value = @"bounce")]
        Bounce,

        [EnumMember(Value = @"linear-in")]
        LinearIn,

        [EnumMember(Value = @"quad-in")]
        QuadIn,

        [EnumMember(Value = @"cubic-in")]
        CubicIn,

        [EnumMember(Value = @"sin-in")]
        SinIn,

        [EnumMember(Value = @"exp-in")]
        ExpIn,

        [EnumMember(Value = @"circle-in")]
        CircleIn,

        [EnumMember(Value = @"elastic-in")]
        ElasticIn,

        [EnumMember(Value = @"back-in")]
        BackIn,

        [EnumMember(Value = @"bounce-in")]
        BounceIn,

        [EnumMember(Value = @"linear-out")]
        LinearOut,

        [EnumMember(Value = @"quad-out")]
        QuadOut,

        [EnumMember(Value = @"cubic-out")]
        CubicOut,

        [EnumMember(Value = @"sin-out")]
        SinOut,

        [EnumMember(Value = @"exp-out")]
        ExpOut,

        [EnumMember(Value = @"circle-out")]
        CircleOut,

        [EnumMember(Value = @"elastic-out")]
        ElasticOut,

        [EnumMember(Value = @"back-out")]
        BackOut,

        [EnumMember(Value = @"bounce-out")]
        BounceOut,

        [EnumMember(Value = @"linear-in-out")]
        LinearInOut,

        [EnumMember(Value = @"quad-in-out")]
        QuadInOut,

        [EnumMember(Value = @"sin-in-out")]
        SinInOut,

        [EnumMember(Value = @"exp-in-out")]
        ExpInOut,

        [EnumMember(Value = @"circle-in-out")]
        CircleInOut,

        [EnumMember(Value = @"elastic-in-out")]
        ElasticInOut,

        [EnumMember(Value = @"back-in-out")]
        BackInOut,

        [EnumMember(Value = @"bounce-in-out")]
        BounceInOut
    }
}
