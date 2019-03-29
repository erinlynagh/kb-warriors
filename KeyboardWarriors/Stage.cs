using System;
using System.Collections.Generic;
using StageType;


public class Stage {
	private int id { get; }
	private StageType stageType { get; }

	public Stage(int id, StageType stageType){
		this.id = id;
		this.stageType = stageType;
	}
}