using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pets.GetById;
public class GetPetByIdUserCase
{
    public ResponsePetJson Execute(int id)
    {
        return new ResponsePetJson 
        { 
            Id = id, 
            Name = "Bragantino", 
            Type = Communication.Enums.PetType.Dog,
            Birthday = new DateTime(year: 2020, month: 01, day: 24),
        };
    }
}
