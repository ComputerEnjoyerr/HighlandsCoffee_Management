using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Table
    {
        private int tableId, branchId, capacity, status;
        private string tableName;

        public Table() { }
        public Table(int tableId, string tableName, int branchId, int capacity, int status)
        {
            this.TableId = tableId;
            this.BranchId = branchId;
            this.TableName = tableName;
            this.Capacity = capacity;
            this.Status = status;
        }

        public int TableId { get => tableId; set => tableId = value; }
        public int BranchId { get => branchId; set => branchId = value; }
        public int Capacity { get => capacity; set => capacity = value; }
        public int Status { get => status; set => status = value; }
        public string TableName { get => tableName; set => tableName = value; }
    }
}
