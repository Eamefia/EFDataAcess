using EFDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scylap.Data.DataAccess
{
    public interface IItemService
    {
        Task<List<ItemModel>> GetAllItemsAsync();
        Task<bool> InsertItemAsync(ItemModel itemModel);
        Task<ItemModel> GetItemAsync(Guid Id);
        Task<ItemModel> DeleteAsync(Guid Id);
        Task<bool> UpdateItemAsync(ItemModel itemModel);
    }
}
