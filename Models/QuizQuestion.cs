﻿namespace BlazorApp4.Models
{
    public class QuizQuestion
    {
        public string QuestionText { get; set; }
        public string ImageUrl { get; set; }
        public List<string> Options { get; set; }
        public string CorrectAnswer { get; set; }
    }
}
