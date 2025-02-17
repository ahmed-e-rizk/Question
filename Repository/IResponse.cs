﻿namespace Question.Repository
{
    public interface IResponse<T>
    {
        public bool IsSuccess { get; set; }
        public List<TErrorField> Errors { get; set; }
        public T Data { get; set; }
        public IResponse<T> CreateResponse(T data);
        public IResponse<T> CreateResponse(Exception ex);
        public IResponse<T> AppendError(TErrorField error);
        public IResponse<T> AppendErrors(List<TErrorField> errors);

    }
}
