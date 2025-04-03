﻿using Entities.Models;
using ETicaret.Infrastructure.Extensions;
using System.Text.Json.Serialization;

namespace ETicaret.Models
{
    public class SessionCart : Cart
    {
        [JsonIgnore]
        public ISession? Session { get; set; }

        public static Cart GetCart(IServiceProvider services)
        {
            ISession? session = services.GetRequiredService<IHttpContextAccessor>().HttpContext?.Session;

            SessionCart cart  = session?.GetJson<SessionCart>("cart") ?? new SessionCart();
            cart.Session = session;
            return cart;
        }

        public override void AddItem(Product product, int quantity)
        {
            base.AddItem(product, quantity);
            Session?.SetJson<SessionCart>("cart", this);
        }

        public override void Clear()
        {
            base.Clear();
            Session?.Remove("cart");
        }

        public override void IncreaseQuantity(Product product, int quantity)
        {
            base.IncreaseQuantity(product, quantity);
            Session?.SetJson<SessionCart>("cart", this);
        }

        public override void DecreaseQuantity(Product product, int quantity)
        {
            base.DecreaseQuantity(product, quantity);
            Session?.SetJson<SessionCart>("cart", this);
        }

        public override void RemoveLine(Product product)
        {
            base.RemoveLine(product);
            Session?.SetJson<SessionCart>("cart", this);
        }

    }
}
