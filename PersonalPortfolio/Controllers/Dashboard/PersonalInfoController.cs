using Microsoft.AspNetCore.Mvc;


namespace PersonalPortfolio.Controllers.Dashboard
{
    //[Route("Dashboard/PersonalInfo")]
    public class PersonalInfoController : Controller
    {
        private readonly IProfile _profile;
        private readonly IMapper _mapper;

        private readonly IWebHostEnvironment _hosting;

        public static string viewPath = Path.Combine("Views", "Dashboard", "PersonalInfo ");
        public PersonalInfoController(IProfile profile, IMapper mapper, IWebHostEnvironment hosting)
        {
            _profile = profile;
            _mapper = mapper;
            _hosting = hosting;
        }

        //[Route("")]
        public async Task<IActionResult> Index()
        {

            var result = await _profile.GetPersonalInfoAsync();

            // Console.WriteLine(viewPath);
            return View("Views/Dashboard/PersonalInfo/Index.cshtml", _mapper.Map<IEnumerable<PersonalInfoVModel>>(result));
        }

        public async Task<IActionResult> Details(int id)
        {
            var result = await _profile.GetPersonalInfoByIDAsync(id);
            return View(_mapper.Map<PersonalInfoVModel>(result));
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View("Views/Dashboard/PersonalInfo/Create.cshtml", new PersonalInfoVModel { });
        }

        [HttpPost]
        public async Task<IActionResult> Create(PersonalInfoVModel personalInfoVModel)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "You must fill all required filed ");
                return View();
            }
            else
            {
                try
                {
                    string fileName = await _profile.CopyFileName(personalInfoVModel.file) ?? string.Empty;
                    var result = _mapper.Map<PersonalInfo>(personalInfoVModel);
                    result.ImageUrl = fileName;
                    await _profile.AddPersonalInfoAsync(result);
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View("Create");
                }
            }
        }


        public async Task<IActionResult> Edit(int id)
        {
            var result = await _profile.GetPersonalInfoByIDAsync(id);
            return View("Views/Dashboard/PersonalInfo/Edit.cshtml", _mapper.Map<PersonalInfoVModel>(result));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(PersonalInfoVModel personalInfoVModel)
        {
            // Console.WriteLine("Model State is not valid");

            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "You must fill all required filed");

                return View("Views/Dashboard/PersonalInfo/Edit.cshtml", personalInfoVModel);
            }
            else
            {
                try
                {
                    // CopyFileName(personalInfoVModel.file, personalInfoVModel.ImageUrl)
                    string fileName = await _profile.CopyFileName(personalInfoVModel.file, personalInfoVModel.ImageUrl) ?? string.Empty;
                    var result = _mapper.Map<PersonalInfo>(personalInfoVModel);
                    result.ImageUrl = fileName;
                    await _profile.UpdatePersonalInfoAsync(result);
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View("Views/Dashboard/PersonalInfo/Edit.cshtml", personalInfoVModel);
                }

            }
        }


        public async Task<IActionResult> Delete(int id)
        {

            var result = await _profile.DeletePersonalInfoAsync(id);
            if (result is null)
            {
                ModelState.AddModelError("", "No Record On ID You Want To Delete");
                return View();
            }

            return RedirectToAction(nameof(Index));
        }


    }
}
