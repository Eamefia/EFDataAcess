using EFDataAccess.Models;
using Scylap.Data.DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDataAccess.DataAccess
{
    public class ItemService : IItemService
    {
        private readonly ItemContext _itemContext;

        public ItemService(ItemContext itemContext)
        {
            _itemContext = itemContext;
        }

        public async Task<List<ItemModel>> GetAllItemsAsync()
        {
            return await _itemContext.Items.ToListAsync();
        }

        public async Task<bool> InsertItemAsync(ItemModel itemModel)
        {
            await _itemContext.Items.AddAsync(itemModel);
            await _itemContext.SaveChangesAsync();
            return true;
        }

        public async Task<ItemModel> GetItemAsync(Guid Id)
        {
            ItemModel itemModel = await _itemContext.Items.FirstOrDefaultAsync(c => c.Id.Equals(Id));
            return itemModel;
        }

        public async Task<ItemModel> DeleteAsync(Guid Id)
        {
            ItemModel itemModel = await _itemContext.Items.FirstOrDefaultAsync(c => c.Id.Equals(Id));
            if(itemModel != null)
            {
                _itemContext.Remove(itemModel);
                await _itemContext.SaveChangesAsync();
            }

            return itemModel;
        }

        public async Task<bool> UpdateItemAsync(ItemModel itemModel)
        {
            _itemContext.Items.Update(itemModel);
            await _itemContext.SaveChangesAsync();
            return true;
        }

    }
}
