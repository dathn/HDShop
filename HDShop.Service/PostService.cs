using HDShop.Data.Infrastructure;
using HDShop.Data.Repositories;
using HDShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDShop.Service
{
    //Bước 1 tạo interface
    public interface IPostService
    {
        void Add(Post post);
        void Update(Post post);
        void Delete(int id);
        IEnumerable<Post> GetAll();
        IEnumerable<Post> GetAllPaging(int page, int pageSize, out int totalRouw);
        Post GetById(int id);
        IEnumerable<Post> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow);
        void SaveChanges();
    }
    public class PostService : IPostService
    {
        //Bước 4: khai báo Repository
        IPostRepository _postRepository;
        //Bước 5: khai báo UnitOfWork
        IUnitOfWork _unitOfWork;
        //Bước 3: Gen contructor
        public PostService(IPostRepository postRepository, IUnitOfWork unitOfWork)
        {
            //BƯớc 6: 
            this._postRepository = postRepository;
            this._unitOfWork = unitOfWork;
        }
        //Bước 2: Implement Interface
        public void Add(Post post)
        {
            _postRepository.Add(post);
        }

        public void Delete(int id)
        {
            _postRepository.Delete(id);
        }

        public IEnumerable<Post> GetAll()
        {
            //Lấy được cả PostCategory
            return _postRepository.GetAll(new string[] { "PostCategory"});
        }

        public IEnumerable<Post> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow)
        {
            //TODO: Select all post by tag
            return _postRepository.GetMultiPaging(x=>x.Status, out totalRow, page, pageSize);
        }

        public IEnumerable<Post> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _postRepository.GetMultiPaging(x => x.Status, out totalRow, page, pageSize);
        }

        public Post GetById(int id)
        {
            return _postRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(Post post)
        {
            _postRepository.Update(post);
        }
    }
}
