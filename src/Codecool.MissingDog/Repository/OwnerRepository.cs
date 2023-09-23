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
            return _data.Owners;
        }

        /// <summary>
        ///     Gets specific owner with given Id.
        /// </summary>
        /// <param name="id">id</param>
        /// <returns> Owner instance or null. </returns>
        public Owner GetOwnerById(int id)
        {
            return _data.Owners.FirstOrDefault(x => x?.Id == id);
        }

        /// <summary>
        ///     Gets count of dogs of specific breed that this owner has.
        /// </summary>
        /// <param name="ownerId">ownerId</param>
        /// <param name="breedId">breedId</param>
        /// <returns> Integer, representing count of Dogs. </returns>
        public int GetCountOfDogsOfSpecificBreedThisOwnerHas(int breedId, int ownerId)
        {
            return GetOwnerById(ownerId)?.Dogs.Count(x => x?.Breed.Id == breedId) ?? 0;
        }

        /// <summary>
        ///     Counts an average dogs activitie levels of owner's with given Id or returns zero.
        /// </summary>
        /// <param name="ownerId">ownerId</param>
        /// <returns> Double, representing average level. </returns>
        public double CountAverageActivityLevelOfThisOwnersDogs(int ownerId)
        {
            return GetOwnerById(ownerId)?.Dogs.Average(x => x?.Breed.ActivityLevel) ?? 0;
        }

        /// <summary>
        ///     Gets the oldest dog of owner with given Id or returns null when none.
        /// </summary>
        /// <param name="ownerId">ownerId</param>
        /// <returns> Dog instance or null </returns>
        public Dog GetOldestDogOfThisOwner(int ownerId)
        {
            return GetOwnerById(ownerId)?.Dogs.Where(x => x != null).OrderBy(x => x?.DateOfBirth).FirstOrDefault();
        }

        /// <summary>
        ///     Count dogs of owner with given Id.
        /// </summary>
        /// <param name="ownerId">ownerId</param>
        /// <returns> Integer, representing Dogs count. </returns>
        public int CountDogsOfThisOwners(int ownerId)
        {
            return GetOwnerById(ownerId)?.Dogs.Count(x => x != null) ?? 0;
        }
    }
}

