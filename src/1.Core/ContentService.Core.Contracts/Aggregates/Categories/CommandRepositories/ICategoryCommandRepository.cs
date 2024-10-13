﻿using ContentService.Core.Domain.Aggregates.Categories;

using Framework.Contract.Persistence.Commands;

namespace ContentService.Core.Contracts.Aggregates.Categories.CommandRepositories;
public interface ICategoryCommandRepository : ICommandRepository<Category>
{
	//اینجا باید متد های مورد نیاز را نوشت
	//هر متدی که در کلاس Base وجود ندارد باید اینجا نوشته شود
	public Task<bool> IsParentCategoryAsync(Guid categoryId, CancellationToken cancellationToken = default);

}