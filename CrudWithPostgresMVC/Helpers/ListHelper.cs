using CrudWithPostgresMVC.Models;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CrudWithPostgresMVC.Helpers
{
    public static class ListHelper
    {
        public static HtmlString CreateParagraph(this IHtmlHelper html, string text)
        {
            var result = $"<h2>{text}<h2/>";
            return new HtmlString(result);
        }

        public static HtmlString CreateImgLabel(this IHtmlHelper html, string path)
        {
            var src = $"{path}";
            return new HtmlString($"<img src={src} style=\"max-width:55px;\" />");
        }

        public static HtmlString CreateList(this IHtmlHelper html, IEnumerable<User> users)
        {
            var result = "<select class = \"select\">";
            foreach (var user in users)
            {
                result = $"{result}<option class = \"option\">{user.FirstName}</option>";

            }
            result = $"{result}</select>";
            return new HtmlString(result);
        }

        public static HtmlString CreateListWithStyles(this IHtmlHelper html, IEnumerable<User> users)
        {
            var result = @$"<div class='card col-md-12'>{CreatePadding(html)}<select class='form-select' size='3'>";
            foreach (var user in users)
            {
                result = $"{result}<option>{user.FullName}</option></div>";
            }
            result = $"{result}</select>{CreatePadding(html)}";
            return new HtmlString(result);
        }

        public static HtmlString CreatePadding(this IHtmlHelper html)
        {
            var indent = "<div style='padding: 5px;'></div>";
            return new HtmlString(indent);
        }

        public static HtmlString CreateFormForQuiz(this IHtmlHelper html)
        {
            var form = $@"
                    <div class='card col-md-12'>
                        <form asp-controller='Quiz' asp-action='SendAnswer' method='post'>
                            <p>
                                <b style='display:flex; justify-content:center'>
                                    <video style='border-radius: 20px;' autoplay controls src='https://ia801006.us.archive.org/7/items/whyareyougay/why%20are%20you%20gay%F0%9F%98%82%F0%9F%98%82.mp4'></video>
                                    <h1 style='margin:auto;'>Why are you gay?</h1>
                                </b>
                            </p>
                            <div style='display:flex; justify-content: center'>
                                <div class='radio-div'>
                                    <input class='radio' id='radio1' type='radio' name='answer' value='1'><label for='radio1'>1</label>
                                </div>
                                <div class='radio-div'>
                                    <input class='radio' id='radio2' type='radio' name='answer' value='2'><label for='radio2'>2</label>
                                </div>
                                <div class='radio-div'>
                                    <input class='radio' id='radio3' type='radio' name='answer' value='3'><label for='radio3'>3</label>
                                </div>
                            </div><hr />
                            <div style='display:flex; justify-content:center; background-color:dimgray;'>
                                <button style='margin:3px;' class='btn btn-primary' type='submit'>Send</button><br />
                            </div>

                        </form>
                    </div>";
            return new HtmlString(form);
        }
    }
}
