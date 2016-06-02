### Erp: Interpolation Utility for Unity

Erp is a small utility for making interpolation in unity a bit more robust.

Say you want a function like `Mathf.Lerp`, but want to use a non linear interpolation?

```C#
Erp.Interpolate(Interpolator.Type.EaseInCubic, start, end, pct);
```

Or do you find yourself doing stuff like this all the time?:

```C#
x = Mathf.Lerp(x, target, dampen);
```

Instead, try the extension methods on `float`:

```C#
x.MoveTowards(target, dampen)
```

Or, use `Tween` which calls a function on every update frame until it's done.

```C#
private void SetScale(float scale) {
  transform.localScale = Vector3.one * scale;
}

private IEnumerator show() {
  // Over one second, move through the interpolation function and call SetScale every frame.
  yield return Erp.Tween(Interpolator.Type.EaseInElastic, 0, 1f, 1.0f, SetScale);
}
```

Wishlist:

- Extend all the interpolators to work on `VectorN` classes, Quaternions.
- Support custom curves, or a component to configure more complex curves in the editor, or some editor extensions for including configurable curves as fields on classes.

