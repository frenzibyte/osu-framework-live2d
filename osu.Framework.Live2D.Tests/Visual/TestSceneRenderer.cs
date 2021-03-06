// Copyright (c) Nitrous <n20gaming2000@gmail.com>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Cubism;
using osu.Framework.Graphics.Containers;
using osuTK;

namespace osu.Framework.Live2D.Tests.Visual
{
    [System.ComponentModel.Description("Rendering models in drawables")]
    public class TestSceneRenderer : TestSceneBase
    {
        protected override Colour4 BackgroundColour => Colour4.Red;

        [BackgroundDependencyLoader]
        private void load(CubismAssetStore cubismAssets)
        {
            Container.Size = new Vector2(512);
            Sprite.Renderer.Y = 0;
            Sprite.Renderer.Scale = Vector2.One;

            AddLabel("container");

            AddSliderStep<float>("width", 128, 684, 512, (float w) => Container.Width = w);
            AddSliderStep<float>("height", 128, 684, 512, (float h) => Container.Height = h);

            AddLabel("model");

            AddSliderStep<float>("scale", 0.5f, 2, 1, (float s) => Sprite.Renderer.Scale = new Vector2(s));
            AddSliderStep<float>("x position", -128, 128, 0, (float x) => Sprite.Renderer.X = x);
            AddSliderStep<float>("y position", -128, 128, 0, (float y) => Sprite.Renderer.Y = y);
        }
    }
}