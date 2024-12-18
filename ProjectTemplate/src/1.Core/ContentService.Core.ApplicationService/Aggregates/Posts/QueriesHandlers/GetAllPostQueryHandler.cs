﻿using ContentService.Core.Contracts.Aggregates.Posts.Queries.GetAll;
using ContentService.Core.Contracts.Aggregates.Posts.Queries.ResultViewModel;
using ContentService.Core.Contracts.Aggregates.Posts.QueryRepositories;

using FluentResults;

using MDF.Framework.LayersContracts.ApplicationServices.MediatorExtensions.CQRS;

namespace ContentService.Core.ApplicationService.Aggregates.Posts.QueriesHandlers;
public class GetAllPostQueryHandler : IQueryHandler<GetAllPostQuery, List<PostQueryResult>>
{
	private IPostQueryRepository _postQueryRepository;

	public GetAllPostQueryHandler(IPostQueryRepository postQueryRepository)
	{
		_postQueryRepository = postQueryRepository;
	}

	public async Task<Result<List<PostQueryResult>>> Handle(GetAllPostQuery request, CancellationToken cancellationToken)
	{
		Result<List<PostQueryResult>> reuslt = new();
		var posts = await _postQueryRepository.ExecuteAsync(request, cancellationToken);
		reuslt.WithValue(posts);
		return reuslt;
	}
}
