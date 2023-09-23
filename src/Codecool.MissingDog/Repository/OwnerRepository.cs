using System;
using Codecool.MissingDog.Model;
using System.Collections.Generic;
using System.Linq;

namespace Codecool.MissingDog.Repository
{
    /// <summary>
    ///     Provides all needed methods on owners data.
    /// </summary>
    public class OwnerRepository
    {
        private DataSource _data { get; }

        /// <summary>
        ///     Initiates a new instance of OwnerRepository based on given DataSource.
        /// </summary>
        /// <param name="data"></param>
        public OwnerRepository(DataSource data)
        {
            _data = data;
        }

        /// <summary>
        ///     Gets all owners from data.
        /// </summary>
        /// <returns> IEnumerable of all Owners instances and nulls. </returns>
        public IEnumerable<Owner> GetAllOwners()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     Gets specific owner with given Id.
        /// </summary>
        /// <param name="id">id</param>
        /// <returns> Owner instance or null. </returns>
        public Owner GetOwnerById(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     Gets count of dogs of specific breed that this owner has.
        /// </summary>
        /// <param name="ownerId">ownerId</param>
        /// <param name="breedId">breedId</param>
        /// <returns> Integer, representing count of Dogs. </returns>
        public int GetCountOfDogsOfSpecificBreedThisOwnerHas(int breedId, int ownerId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     Counts an average dogs activitie levels of owner's with given Id or returns zero.
        /// </summary>
        /// <param name="ownerId">ownerId</param>
        /// <returns> Double, representing average level. </returns>
        public double CountAverageActivityLevelOfThisOwnersDogs(int ownerId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     Gets the oldest dog of owner with given Id or returns null when none.
        /// </summary>
        /// <param name="ownerId">ownerId</param>
        /// <returns> Dog instance or null </returns>
        public Dog GetOldestDogOfThisOwner(int ownerId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     Count dogs of owner with given Id.
        /// </summary>
        /// <param name="ownerId">ownerId</param>
        /// <returns> Integer, representing Dogs count. </returns>
        public int CountDogsOfThisOwners(int ownerId)
        {
            throw new NotImplementedException();
        }
    }
}

