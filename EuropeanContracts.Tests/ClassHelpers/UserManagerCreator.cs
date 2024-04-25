using EuropeanContracts.Data;
using EuropeanContracts.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace EuropeanContracts.Tests.ClassHelpers
{
    public static class UserManagerCreator
    {
        public static UserManager<EuropeanContractUser> Create(EuropeanContractsDbContext context)
        {
            var userStore = new UserStore<EuropeanContractUser>(context);
            var hasher = new PasswordHasher<EuropeanContractUser>();
            var normalizer = new UpperInvariantLookupNormalizer();
            var userManager = new UserManager<EuropeanContractUser>(userStore,
                                                                    null,
                                                                    hasher,
                                                                    null,
                                                                    null,
                                                                    normalizer,
                                                                    null,
                                                                    null,
                                                                    null);
            return userManager;
        }
    }
}
