const factionList = document.getElementById("factionList")
const addfaction = document.getElementById("addFactionInput")

async function Load(){
    factionList.innerHTML = "Fetching Factions"
    response = await fetch("/factions")
    result = await response.json()
    console.log(result)

    const factions = result.factions
    if (!response.ok) {
        factionList.innerHTML = "Failed to load"
        return
    }
    factionList.innerHTML = ""
    for (item of factions){
        console.log(item)
        const li = document.createElement("li")
        li.innerHTML = item
        factionList.appendChild(li)
    }
}

async function Create(){
    console.log(addfaction.value)
    response = await fetch("/faction", {
        method:"POST",
        headers:{"Content-Type":"Application/JSON"},
        body: JSON.stringify({newFaction :addfaction.value})
    })
    
    result = await response.json()
    console.log(result)
    if (response.ok){
        Load()
    }
}

async function Delete(){
    response = await fetch("/faction",{
        method:"DELETE"
    })
    result = await response.json()
    console.log(result)
    if (response.ok) {
        
        Load()
        alert(result.Message)
        return
    }else{
        alert("delete failed")
    }
    }
Load()