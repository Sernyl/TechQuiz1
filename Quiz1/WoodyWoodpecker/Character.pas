unit Character;

interface

type
  TCharacter = class
    public
      procedure Intro;
  end;

implementation

uses
  SysUtils;

procedure TCharacter.Intro;
begin
  Writeln('Universal International ������������');
  Writeln('- ������, ����? *������� ����*');
end;

end.