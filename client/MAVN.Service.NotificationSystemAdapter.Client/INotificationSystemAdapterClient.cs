using JetBrains.Annotations;

namespace MAVN.Service.NotificationSystemAdapter.Client
{
    /// <summary>
    /// NotificationSystemAdapter client interface.
    /// </summary>
    [PublicAPI]
    public interface INotificationSystemAdapterClient
    {
        // Make your app's controller interfaces visible by adding corresponding properties here.
        // NO actual methods should be placed here (these go to controller interfaces, for example - INotificationSystemAdapterApi).
        // ONLY properties for accessing controller interfaces are allowed.

        /// <summary>Application Api interface</summary>
        INotificationSystemAdapterApi Api { get; }
    }
}
