using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SfDataGridSample
{
    public class OrderInfoRepository
    {
        private ObservableCollection<OrderInfo> orderInfo;
        public ObservableCollection<OrderInfo> OrderInfoCollection
        {
            get { return orderInfo; }
            set { this.orderInfo = value; }
        }

        public OrderInfoRepository()
        {
            orderInfo = new ObservableCollection<OrderInfo>();
            this.GenerateOrders();
        }

        public void GenerateOrders()
        {
            orderInfo.Add(new OrderInfo("1001", "Maria Anders", "Germany", "ALFKI", "Berlin", new DateTime(2024, 1, 15, 10, 30, 0)));
            orderInfo.Add(new OrderInfo("1002", "Ana Trujillo", "Mexico", "ANATR", "Mexico D.F.", new DateTime(2024, 2, 20, 14, 45, 0)));
            orderInfo.Add(new OrderInfo("1003", "Ant Fuller", "Mexico", "ANTON", "Mexico D.F.", new DateTime(2024, 3, 10, 9, 15, 0)));
            orderInfo.Add(new OrderInfo("1004", "Thomas Hardy", "UK", "AROUT", "London", new DateTime(2024, 4, 5, 11, 0, 0)));
            orderInfo.Add(new OrderInfo("1005", "Tim Adams", "Sweden", "BERGS", "London", new DateTime(2024, 5, 12, 16, 20, 0)));
            orderInfo.Add(new OrderInfo("1006", "Hanna Moos", "Germany", "BLAUS", "Mannheim", new DateTime(2024, 6, 8, 8, 45, 0)));
            orderInfo.Add(new OrderInfo("1007", "Andrew Fuller", "France", "BLONP", "Strasbourg", new DateTime(2024, 7, 22, 13, 30, 0)));
            orderInfo.Add(new OrderInfo("1008", "Martin King", "Spain", "BOLID", "Madrid", new DateTime(2024, 8, 3, 10, 0, 0)));
            orderInfo.Add(new OrderInfo("1009", "Lenny Lin", "France", "BONAP", "Marsiella", new DateTime(2024, 9, 18, 15, 45, 0)));
            orderInfo.Add(new OrderInfo("1010", "John Carter", "Canada", "BOTTM", "Lenny Lin", new DateTime(2024, 10, 25, 12, 0, 0)));
            orderInfo.Add(new OrderInfo("1011", "Laura King", "UK", "AROUT", "London", new DateTime(2024, 11, 14, 9, 30, 0)));
            orderInfo.Add(new OrderInfo("1012", "Anne Wilson", "Germany", "BLAUS", "Mannheim", new DateTime(2024, 12, 7, 14, 15, 0)));
            orderInfo.Add(new OrderInfo("1013", "Martin King", "France", "BLONP", "Strasbourg", new DateTime(2025, 1, 9, 11, 45, 0)));
            orderInfo.Add(new OrderInfo("1014", "Gina Irene", "UK", "AROUT", "London", new DateTime(2025, 2, 28, 16, 0, 0)));
        }
    }
}
