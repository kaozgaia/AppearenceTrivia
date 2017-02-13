using System.Collections;
using Utils;
public class ComponentModel {
    public string Name { get; set; }
    public eColor Color { get; set; }
    public eClothType Type { get; set; }
    public eComponentType Required { get; set; }

    public ComponentModel() { }

    public ComponentModel(string _name, eColor _color, eClothType _type, eComponentType _required)
    {
        this.Name = _name;
        this.Color = _color;
        this.Type = _type;
        this.Required = _required;
    }
}
