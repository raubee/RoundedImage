// uv : UV1
// w : width
// h : height
// r : radius
float RoundClip(float2 uv, float w, float h, float r)
{
	float2 wh = float2(w, h);
	float2 nUV = (uv - 0.5) * wh + .5;
	float2 muv = abs(nUV * 2 - 1) - wh + r * 2 ;
	float d = length(max(0, muv)) / (r * 2);

	float fw = fwidth(d);
	if(fw <= .0) fw = 0.001;
	return saturate((1.-d) / fw);
}
