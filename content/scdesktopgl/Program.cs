using ScapeCore.Core.Engine;
using ScapeCore.Core.SceneManagement;
using scdesktopgl;
using System.Threading.Tasks;

using var game = new ScapeCore.Core.Targets.LLAM(typeof(ResourceManager));
var t = Task.Run(() => game.Run());
var defaultScene = new Scene("Scene", 0);

SceneManager.AddScene(defaultScene);
SceneManager.SetCurrentScene(0);

var sample = defaultScene.AddToScene<Sample>();
t.Wait();