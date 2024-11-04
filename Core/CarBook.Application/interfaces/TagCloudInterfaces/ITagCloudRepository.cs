using Carbook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.interfaces.TagCloudInterfaces
{
	public interface ITagCloudRepository
	{
		List<TagCloud> GetTagCloudsByBlogID(int id);
	}
}
