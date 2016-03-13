using KRPC.Service.Attributes;

namespace KRPC.SpaceCenter.Services.Parts
{
    /// <summary>
    /// See <see cref="CargoBay.State"/>.
    /// </summary>
    [KRPCEnum (Service = "SpaceCenter")]
    public enum CargoBayState
    {
        /// <summary>
        /// Cargo bay is fully open.
        /// </summary>
        Open,
        /// <summary>
        /// Cargo bay closed and locked.
        /// </summary>
        Closed,
        /// <summary>
        /// Cargo bay is opening.
        /// </summary>
        Opening,
        /// <summary>
        /// Cargo bay is closing.
        /// </summary>
        Closing
    }
}
