type Part() =
    let world = World()

    member this.Run() =
        let teenager = Teenager()

        teenager.Teach()
        if teenager.Test() then return true

        world.SaveBy(teenager)

        teenager.IsGentleman()

type Teenager() =
    member this.Teach() = ()

    member this.Test() = true

    member this.IsGentleman() = true

type World() =
    member this.SaveBy(teenager: Teenager) = ()