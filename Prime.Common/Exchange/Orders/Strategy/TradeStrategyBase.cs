using System.Linq;
using System.Threading;
using GalaSoft.MvvmLight.Messaging;
using LiteDB;
using Prime.Common.Exchange.Trading_temp.Messages;
using Prime.Common;

namespace Prime.Common.Exchange.Trading_temp
{
    public abstract class TradeStrategyBase : ITradeStrategy
    {
        protected readonly IMessenger M = DefaultMessenger.I.Default;
        protected readonly IOrderLimitProvider Provider;
        protected TradeStrategyStatus Status;
        public ObjectId Id { get; }
        public string RemoteTradeId { get; protected set; }

        protected TradeStrategyBase(TradeStrategyContext context)
        {
            Context = context;
            Id = ObjectId.NewObjectId();
            Provider = Context.Network.Providers.Where(x=>x.IsDirect).FirstProviderOf<IOrderLimitProvider>();
        }

        public TradeStrategyContext Context { get; }

        public virtual void Start()
        {
            Status = TradeStrategyStatus.Started;
        }

        public virtual void Cancel()
        {
            SetStatus(TradeStrategyStatus.Cancelled);
        }

        protected void SetComplete()
        {
            SetStatus(TradeStrategyStatus.Completed);
        }

        public virtual TradeStrategyStatus GetStatus()
        {
            return Status;
        }

        private void SetStatus(TradeStrategyStatus status)
        {
            if (status == Status)
                return;

            Status = status;
            M.SendAsync(new TradeStatusChangedMessage(Id, Status));
        }
    }
}