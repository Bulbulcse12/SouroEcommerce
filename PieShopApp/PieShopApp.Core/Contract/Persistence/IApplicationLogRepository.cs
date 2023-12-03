﻿using PieShopApp.Core.Model;

namespace PieShopApp.Core.Contract.Persistence;

public interface IApplicationLogRepository
{
	Task<PaginatedListModel<ApplicationLogModel>> GetApplicationLogs(int pageNumber);
	Task<ApplicationLogModel> GetApplicationLogById(int applicationLogId);
	Task DeleteApplicationLog(int applicationLogId);
	Task<List<ApplicationLogModel>> Export();
}