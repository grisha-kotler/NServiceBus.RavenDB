namespace NServiceBus.RavenDB.Persistence.SubscriptionStorage
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using NServiceBus.Persistence.RavenDB;
    using NServiceBus.Unicast.Subscriptions;

    class Subscription
    {
        public string Id { get; set; }

        [JsonConverter(typeof(MessageTypeConverter))]
        public MessageType MessageType { get; set; }

        public List<SubscriptionClient> Subscribers
        {
            get
            {
                subscribers ??= new List<SubscriptionClient>();

                return subscribers;
            }

            set
            {
                subscribers = value;
            }
        }

        List<SubscriptionClient> subscribers;

        internal static readonly string SchemaVersion = "1.0.0";
    }
}